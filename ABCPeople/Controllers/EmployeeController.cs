using AbcPeople.BDO.Entities;
using AbcPeople.BDO.Entities.Base;
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
        private readonly ICourseService courseService;
        private readonly IEmployeeCourseService employeeCourseService;

        public EmployeeController(IEmployeeService employeeService, 
                                  IProfileAdjustmentService profileAdjustmentService,
                                  ILanguageService languageService,
                                  INationalityService nationalityService,
                                  IRoleService roleService,
                                  IFamilySituationService familySituationService,
                                  ICertificateService certificateService,
                                  IEmployeeCertificateService employeeCertificateService,
                                  IExamService examService,
                                  IEmployeeExamService employeeExamService,
                                  ICourseService courseService,
                                  IEmployeeCourseService employeeCourseService)
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
            this.courseService = courseService;
            this.employeeCourseService = employeeCourseService;
        }

        private Employee GetCurrentEmployee()
        {
            return this.employeeService.Get(4,
                                 x => x.Include(y => y.HomeAddress).ThenInclude(x => x.City)
                                       .Include(y => y.MotherLanguage)
                                       .Include(y => y.FamilySituation)
                                       .Include(y => y.Role)
                                       .Include(y => y.ProfileAdjustments)
                                       .Include(y => y.Nationality)
                                       .Include(y => y.WorkExperiences).ThenInclude(x => x.Role)
                                       .Include(y => y.WorkExperiences).ThenInclude(x => x.PlaceOfWorkAddress)
                                       .Include(y => y.LanguageSkills)
                                       .Include(y => y.EmployeeCertificates).ThenInclude(x => x.Certificate)
                                       .Include(y => y.EmployeeExams).ThenInclude(x => x.Exam));
        }

        public IActionResult ProfileInfo()
        {
            return View(GetCurrentEmployee());
        }

        public IActionResult ProfileInfoEdit()
        {
            ProfileInfoViewModel profileInfoViewModel = new ProfileInfoViewModel()
            {
                Employee = GetCurrentEmployee(),
                Languages = InitializeSelectListItems(this.languageService.GetAll()),
                Nationalities = InitializeSelectListItems(this.nationalityService.GetAll()),
                Roles = InitializeSelectListItems(this.roleService.GetAll()),
                FamilySituations = InitializeSelectListItems(this.familySituationService.GetAll())
            };
            return View("ProfileInfoEdit", profileInfoViewModel);
        }

        private List<SelectListItem> InitializeSelectListItems(IEnumerable<BaseEntity> allEntities)
        {
            var SelectListItems = new List<SelectListItem>();
            foreach (var baseEntity in allEntities)
            {
                SelectListItems.Add(new SelectListItem { 
                                    Value = baseEntity.Id.ToString(), 
                                    Text = baseEntity.GetType().GetProperty("Name").GetValue(baseEntity, null).ToString()
                }) ;
            }
            return SelectListItems;
        }

        [HttpPost]
        public IActionResult SaveEditProfileUser(int id, [Bind("Employee")] ProfileInfoViewModel profileInfoViewModel)
        {
            this.employeeService.Update(profileInfoViewModel.Employee, 
                                 x => x.Include(y => y.HomeAddress)
                                       .Include(y => y.MotherLanguage)
                                       .Include(y => y.FamilySituation)
                                       .Include(y => y.Nationality)
                                       .Include(y => y.Role));
            return View("ProfileInfo", GetCurrentEmployee());
        }
        public IActionResult ProfileWorkExperiences()
        {
            return View(GetCurrentEmployee().WorkExperiences);
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
                Employee = GetCurrentEmployee(),
                Certificates = certificates,
                EmployeeCertificate = new EmployeeCertificate()
                {
                    EmployeeId = GetCurrentEmployee().Id
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
            return View("ProfileEducations", GetCurrentEmployee());
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
                EmployeeId = GetCurrentEmployee().Id,
                ExamId = profileEducationAddExamViewModel.EmployeeExam.ExamId,
                Date = profileEducationAddExamViewModel.EmployeeExam.Date
            });
            return View("ProfileEducations", GetCurrentEmployee());
        }

        public IActionResult ShowAddCourseView()
        {
            var courses = new List<SelectListItem>();
            foreach (var item in this.courseService.GetAll())
            {

            }
            var vm = new ProfileEducationAddCourseViewModel();
            return View("ProfileEducationAddCourse");
        }

        public IActionResult SaveEmployeeCourse()
        {
            // save data
            return View("ProfileEducations", GetCurrentEmployee());
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
            return View(GetCurrentEmployee());
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
