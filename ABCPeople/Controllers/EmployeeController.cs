﻿using AbcPeople.BDO.Entities;
using AbcPeople.BDO.Entities.Base;
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
                                       .Include(y => y.SocialNetwork)
                                       .Include(y => y.WorkExperiences).ThenInclude(x => x.Role)
                                       .Include(y => y.WorkExperiences).ThenInclude(x => x.PlaceOfWorkAddress).ThenInclude(x => x.City)
                                       .Include(y => y.LanguageSkills)
                                       .Include(y => y.EmployeeCertificates).ThenInclude(x => x.Certificate)
                                       .Include(y => y.EmployeeExams).ThenInclude(x => x.Exam)
                                       .Include(y => y.EmployeeEducations).ThenInclude(x => x.Education)
                                       .Include(y => y.EmployeeCourses).ThenInclude(x => x.Course));
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

        [HttpPost]
        public IActionResult SaveEditProfileUser(int id, [Bind("Employee")] ProfileInfoViewModel profileInfoViewModel)
        {
            this.employeeService.Update(profileInfoViewModel.Employee, 
                                 x => x.Include(y => y.HomeAddress)
                                       .Include(y => y.MotherLanguage)
                                       .Include(y => y.FamilySituation)
                                       .Include(y => y.Nationality)
                                       .Include(y => y.SocialNetwork)
                                       .Include(y => y.Role));
            return View("ProfileInfo", GetCurrentEmployee());
        }
        public IActionResult ProfileWorkExperiences()
        {
            return View(GetCurrentEmployee().WorkExperiences);
        }
        public IActionResult EditWorkExperience(int workExperienceId)
        {
            // todo : saving Edited work Experience using a viewmodel
            // todo : passing data from View to action in controller (Html.ActionLink)
            ProfileWorkExperienceEditViewModel profileWorkExperienceEditViewModel = new ProfileWorkExperienceEditViewModel() 
            { 

            };

            return View("ProfileWorkExperienceEdit");
        }
        
        public IActionResult AddNewWorkExperience()
        {
            return View("ProfileWorkExperienceNew");
        }

        public IActionResult AddLanguageSkills()
        {
            //saven
            return View("ProfileAddLanguageSkill");
        }
        public IActionResult ShowAddCertification()
        {
            ProfileEducationAddCertificateViewModel vm = new ProfileEducationAddCertificateViewModel()
            {
                Employee = GetCurrentEmployee(),
                Certificates = InitializeSelectListItems(this.certificateService.GetAll()),
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
            //return View("ProfileEducations", GetCurrentEmployee());
            return RedirectToAction("ProfileEducations");
        }

        public IActionResult ShowAddEmployeeExamView()
        {
            var vm = new ProfileEducationAddExamViewModel()
            {
                EmployeeExam = new EmployeeExam(),
                Exams = InitializeSelectListItems(this.examService.GetAll())
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
            return RedirectToAction("ProfileEducations");
        }

        public IActionResult ShowAddCourseView()
        {
            var vm = new ProfileEducationAddCourseViewModel() 
            { 
                Course = new Course(),
                EmployeeCourse = new EmployeeCourse()
            };
            return View("ProfileEducationAddCourse", new EmployeeCourse());
        }

        public IActionResult SaveEmployeeCourse(EmployeeCourse employeeCourse)
        {
            employeeCourse.EmployeeId = GetCurrentEmployee().Id;
            this.employeeCourseService.Create(employeeCourse);
           
            return RedirectToAction("ProfileEducations");
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

        // Helper - methods
        private List<SelectListItem> InitializeSelectListItems(IEnumerable<ListItemBaseEntity> allEntities)
        {
            var SelectListItems = new List<SelectListItem>();
            foreach (var baseEntity in allEntities)
            {
                SelectListItems.Add(new SelectListItem { Value = baseEntity.Id.ToString(), Text = baseEntity.Name });
            }
            return SelectListItems;
        }
    }
}
