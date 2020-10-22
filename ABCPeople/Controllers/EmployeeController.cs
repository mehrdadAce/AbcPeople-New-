using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AbcPeople.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IProfileAdjustmentService profileAdjustmentService;
        private readonly ILanguageService languageService;

        public EmployeeController(IEmployeeService employeeService, 
            IProfileAdjustmentService profileAdjustmentService,
            ILanguageService languageService)
        {
            this.employeeService = employeeService;
            this.profileAdjustmentService = profileAdjustmentService;
            this.languageService = languageService;
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
            var currentEmployee = this.employeeService.Get(4, x => x.Include(y => y.ProfileAdjustments));
            return View(currentEmployee);
        }

        public IActionResult ProfileInfoEdit() // ProfileInfoEdit - EditProfileUser
        {
            //Employee currentUser = this.employeeService.Get(4, x => x.Include(y => y.HomeAddress));

            var test = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "engels" },
                new SelectListItem { Value = "2", Text = "Nederlands" },
                new SelectListItem { Value = "3", Text = "Duits"  },
            };

            ProfileInfoViewModel profileInfoViewModel = new ProfileInfoViewModel()
            {
                Employee = this.employeeService.Get(4, x => x.Include(y => y.HomeAddress)),
                Languages = test
            };
            return View("ProfileInfoEdit", profileInfoViewModel);
        }

        [HttpPost]
        public IActionResult SaveEditProfileUser(int id, [Bind("Employee")] ProfileInfoViewModel profileInfoViewModel)
        {
            //this.employeeService.Update(employee);
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
