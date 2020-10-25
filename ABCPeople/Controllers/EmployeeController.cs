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

        public EmployeeController(IEmployeeService employeeService, 
                                  IProfileAdjustmentService profileAdjustmentService,
                                  ILanguageService languageService,
                                  INationalityService nationalityService)
        {
            this.employeeService = employeeService;
            this.profileAdjustmentService = profileAdjustmentService;
            this.languageService = languageService;
            this.nationalityService = nationalityService;
        }

        //public IActionResult Index()
        //{
        //    var employeeViewModel = new EmployeeViewModel()
        //    {
        //        Employees = this.employeeRepository.GetAll(),
        //        ProfileAdjustments = this.profileAdjustmentRepository.GetAllAdjustments()
        //    };

        //    return View(employeeViewModel);
        //}

        public IActionResult ProfileInfo()
        {
            var currentEmployee = this.employeeService.Get(4, x => x.Include(y => y.ProfileAdjustments).Include(y => y.MotherLanguage));
            return View(currentEmployee);
        }

        public IActionResult ProfileInfoEdit() // ProfileInfoEdit - EditProfileUser
        {
            //Employee currentUser = this.employeeService.Get(4, x => x.Include(y => y.HomeAddress));

            IEnumerable<Language> languages = this.languageService.GetAll();
            var languageSelectListItem = new List<SelectListItem>();
            foreach (Language language in languages)
            {
                languageSelectListItem.Add(new SelectListItem { Value = language.Id.ToString(), Text = language.Name });
            }

            var nationalities = this.nationalityService.GetAll();
            var nationalitySelectListItem = new List<SelectListItem>();
            foreach (Nationality nationality in nationalities)
            {
                nationalitySelectListItem.Add(new SelectListItem { Value = nationality.Id.ToString(), Text = nationality.Name });
            }

            ProfileInfoViewModel profileInfoViewModel = new ProfileInfoViewModel()
            {
                Employee = this.employeeService.Get(4, x => x.Include(y => y.HomeAddress)),
                Languages = languageSelectListItem,
                Nationalities = nationalitySelectListItem
            };
            return View("ProfileInfoEdit", profileInfoViewModel);
        }

        [HttpPost]
        public IActionResult SaveEditProfileUser(int id, [Bind("Employee, LanguageId, NationalityId")] ProfileInfoViewModel profileInfoViewModel)
        {
            //this.employeeService.Update(employee);
            profileInfoViewModel.Employee.MotherLanguage = this.languageService.Get(Int32.Parse(profileInfoViewModel.LanguageId));
            profileInfoViewModel.Employee.Nationality = this.nationalityService.Get(Int32.Parse(profileInfoViewModel.NationalityId));
            this.employeeService.Update(profileInfoViewModel.Employee);
            return View("ProfileInfo", profileInfoViewModel.Employee);
        }
        public IActionResult ProfileWorkExperiences()
        {
            return View();
        }

        public IActionResult GoToWhoIsWho()
        {
            return View("WhoIsWho");
        }

        public IActionResult AddCertification()
        {
            return View("Certificate");
        }

        public IActionResult AddLanguageSkills()
        {
            //saven
            return View("LanguageSkill");
        }

        public IActionResult AddCourse()
        {
            return View("Course");
        }

        public IActionResult AddExams()
        {
            return View("Exam");
        }

        public IActionResult AddEducation()
        {
            return View("Education");
        }

        public IActionResult AddNewWorkExperience()
        {
            return View("NewWorkExperience");
        }

        public IActionResult ProfileEducations()
        {
            return View();
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
