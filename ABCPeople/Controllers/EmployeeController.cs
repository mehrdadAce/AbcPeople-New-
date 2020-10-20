using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AbcPeople.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IProfileAdjustmentService profileAdjustmentService;

        public EmployeeController(IEmployeeService employeeService, IProfileAdjustmentService profileAdjustmentService)
        {
            this.employeeService = employeeService;
            this.profileAdjustmentService = profileAdjustmentService;
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
            var currentEmployee = this.employeeService.Get(1, x => x.Include(y => y.ProfileAdjustments));
            return View(currentEmployee);
        }

        public IActionResult EditProfileUser() // ProfileInfoEdit
        {
            Employee currentUser = this.employeeService.Get(1);   // ?????????????????
            return View(currentUser);
        }

        public IActionResult SaveEditProfileUser()
        {
            var currentEmployee = this.employeeService.Get(1);  // ?????????????????????
            return View("ProfileInfo", currentEmployee);
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

        public IActionResult ProfileWorkExperiences()
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
    }
}
