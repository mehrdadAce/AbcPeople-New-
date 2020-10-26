using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AbcPeople.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IProfileAdjustmentService profileAdjustmentService;
        private readonly ILanguageService languageService;
        private readonly INationalityService nationalityService;
        private readonly IRoleService roleService;
        private readonly IFamilySituationService familySituationService;
        private readonly ICertificateService certificateService;
        private readonly IEmployeeCertificateService employeeCertificateService;
        private readonly IExamService examService;
        private readonly IEmployeeExamService employeeExamService;
        private Employee currentEmployee;

        public EmployeeController(IEmployeeService employeeService, 
                                  IProfileAdjustmentService profileAdjustmentService,
                                  ILanguageService languageService,
                                  INationalityService nationalityService,
                                  IRoleService roleService,
                                  IFamilySituationService familySituationService,
                                  ICertificateService certificateService,
                                  IEmployeeCertificateService employeeCertificateService,
                                  IExamService examService,
                                  IEmployeeExamService employeeExamService)
        {
            this.employeeService = employeeService;
            this.profileAdjustmentService = profileAdjustmentService;
            this.languageService = languageService;
            this.nationalityService = nationalityService;
            this.roleService = roleService;
            this.familySituationService = familySituationService;
            this.certificateService = certificateService;
            this.employeeCertificateService = employeeCertificateService;
            this.examService = examService;
            this.employeeExamService = employeeExamService;
            RefreshEmployee();
        }

        private void RefreshEmployee()
        {
            this.currentEmployee = this.employeeService.Get(4,
                                 x => x.Include(y => y.HomeAddress)
                                       .Include(y => y.PlaceOfWorkAddress)
                                       .Include(y => y.MotherLanguage)
                                       .Include(y => y.FamilySituation)
                                       .Include(y => y.Role)
                                       .Include(y => y.ProfileAdjustments)
                                       .Include(y => y.Nationality)
                                       .Include(y => y.WorkExperiences).ThenInclude(x => x.Role)
                                       .Include(y => y.LanguageSkills)
                                       .Include(y => y.EmployeeCertificates).ThenInclude(x => x.Certificate)
                                       .Include(y => y.EmployeeExams).ThenInclude(x => x.Exam));
        }

        public IActionResult ProfileInfo()
        {
            return View(this.currentEmployee);
        }

        public IActionResult ProfileInfoEdit()
        {
            var languageSelectListItem = new List<SelectListItem>();
            foreach (Language language in this.languageService.GetAll())
            {
                languageSelectListItem.Add(new SelectListItem { Value = language.Id.ToString(), Text = language.Name });
            }

            var nationalitySelectListItem = new List<SelectListItem>();
            foreach (Nationality nationality in this.nationalityService.GetAll())
            {
                nationalitySelectListItem.Add(new SelectListItem { Value = nationality.Id.ToString(), Text = nationality.Name });
            }

            var roleSelectListItem = new List<SelectListItem>();
            foreach (Role role in this.roleService.GetAll())
            {
                roleSelectListItem.Add(new SelectListItem { Value = role.Id.ToString(), Text = role.Name });
            }

            var familySituationSelectListItem = new List<SelectListItem>();
            foreach (FamilySituation familySituation in this.familySituationService.GetAll())
            {
                familySituationSelectListItem.Add(new SelectListItem { Value = familySituation.Id.ToString(), Text = familySituation.Name });
            }

            ProfileInfoViewModel profileInfoViewModel = new ProfileInfoViewModel()
            {
                Employee = this.employeeService.Get(4, 
                                 x => x.Include(y => y.HomeAddress)
                                       .Include(y => y.PlaceOfWorkAddress)
                                       .Include(y => y.MotherLanguage)
                                       .Include(y => y.FamilySituation)
                                       .Include(y => y.Role)
                                       .Include(y => y.Nationality)),
                Languages = languageSelectListItem,
                Nationalities = nationalitySelectListItem,
                Roles = roleSelectListItem,
                FamilySituations = familySituationSelectListItem
            };
            return View("ProfileInfoEdit", profileInfoViewModel);
        }

        [HttpPost]
        public IActionResult SaveEditProfileUser(int id, [Bind("Employee")] ProfileInfoViewModel profileInfoViewModel)
        {
            this.employeeService.Update(profileInfoViewModel.Employee, 
                                 x => x.Include(y => y.HomeAddress)
                                       .Include(y => y.PlaceOfWorkAddress)
                                       .Include(y => y.MotherLanguage)
                                       .Include(y => y.FamilySituation)
                                       .Include(y => y.Nationality)
                                       .Include(y => y.Role));
            return View("ProfileInfo", this.currentEmployee);
        }
        public IActionResult ProfileWorkExperiences()
        {
            return View(this.currentEmployee.WorkExperiences);
        }
        public IActionResult AddNewWorkExperience()
        {
            return View("ProfileNewWorkExperience");
        }
        public IActionResult AddLanguageSkills()
        {
            //saven
            return View("ProfileAddLanguageSkill");
        }
        public IActionResult ShowAddCertification()
        {
            var certificates = new List<SelectListItem>();
            foreach (var item in this.certificateService.GetAll())
            {
                certificates.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Title });
            }
            ProfileEducationAddCertificateViewModel vm = new ProfileEducationAddCertificateViewModel()
            {
                Employee = this.currentEmployee,
                Certificates = certificates,
                EmployeeCertificate = new EmployeeCertificate()
                {
                    EmployeeId = this.currentEmployee.Id
                }
            };
            return View("ProfileEducationAddCertificate", vm);
        }

        [HttpPost]
        public IActionResult SaveEmployeeCertificate(int id, [Bind("Employee,EmployeeCertificate")] ProfileEducationAddCertificateViewModel profileEducationAddCertificateViewModel)
        {
            this.employeeCertificateService.Create(new EmployeeCertificate() { 
                EmployeeId = profileEducationAddCertificateViewModel.Employee.Id, 
                CertificateId = profileEducationAddCertificateViewModel.EmployeeCertificate.CertificateId,
                Date = profileEducationAddCertificateViewModel.EmployeeCertificate.Date
            });
            RefreshEmployee();
            return View("ProfileEducations", this.currentEmployee);
        }

        public IActionResult ShowAddEmployeeExamView()
        {
            var exams = new List<SelectListItem>();
            foreach (var item in this.examService.GetAll())
            {
                exams.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Title });
            }
            var vm = new ProfileEducationAddExamViewModel()
            {
                EmployeeExam = new EmployeeExam(),
                Exams = exams
            };
            return View("ProfileEducationAddExam", vm);
        }

        public IActionResult SaveEmployeeExam([Bind("EmployeeExam")] ProfileEducationAddExamViewModel profileEducationAddExamViewModel)
        {
            this.employeeExamService.Create(new EmployeeExam()
            {
                EmployeeId = this.currentEmployee.Id,
                ExamId = profileEducationAddExamViewModel.EmployeeExam.ExamId,
                Date = profileEducationAddExamViewModel.EmployeeExam.Date
            });
            RefreshEmployee();
            return View("ProfileEducations", this.currentEmployee);
        }

        public IActionResult AddCourse()
        {
            return View("ProfileEducationAddCourse");
        }

        public IActionResult AddEducation()
        {
            return View("ProfileEducationAddEducation");
        }

        public IActionResult GoToWhoIsWho()
        {
            return View("WhoIsWho");
        }

        public IActionResult ProfileEducations()
        {
            return View(this.currentEmployee);
        }
       
        public IActionResult ProfileCompetencies()
        {
            return View();
        }

        public IActionResult ProfileCV()
        {
            return View();
        }
        public IActionResult ShowWhoIsWhoName()
        {
            return View("WhoIsWhoName");
        }

        public IActionResult ShowWhoIsWhoFunctionAndDomain()
        {
            return View("WhoIsWhoFunctionAndDomain");
        }

        public IActionResult ShowWhoIsWhoCertificate()
        {
            return View("WhoIsWhoCertificate");
        }

        public IActionResult ShowWhoIsWhoCompany()
        {
            return View("WhoIsWhoCompany");
        }
    }
}
