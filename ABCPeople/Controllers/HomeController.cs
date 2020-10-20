using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABCPeople.Web.Models;
using AbcPeople.BLL.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using AbcPeople.ViewModels;

namespace ABCPeople.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IWorkExperienceService workExperienceService;
        private readonly IAddressService addressService;
        private readonly ILogger<HomeController> _logger;
        private readonly IProfileAdjustmentService profileAdjustmentService;

        public HomeController(ILogger<HomeController> logger, 
                              IEmployeeService employeeService, 
                              IWorkExperienceService workExperienceService, 
                              IAddressService addressService,
                              IProfileAdjustmentService profileAdjustmentService)
        {
            _logger = logger;
            this.employeeService = employeeService;
            this.workExperienceService = workExperienceService;
            this.addressService = addressService;
            this.profileAdjustmentService = profileAdjustmentService;
        }

        public IActionResult Index()
        {
            //var employee = new AbcPeople.BDO.Entities.Employee()
            //{
            //    Id = 1,
            //    FirstName = "Mehrdad",
            //    LastName = "Kazemi",
            //    BeginDateOfWork = new DateTime(2020, 09, 28),
            //    DateOfBirth = new DateTime(1985, 10, 11),
            //    Email = "Mehrdad.Kazemi@ac-e.be",
            //    EmployeeTitle = "ACE - Junior .NET Consultant",
            //    FamilySituation = "Aleenstaand",
            //    Gender = 'M',
            //    MotherLanguage = "Persian",
            //    Nationality = "Belg",
            //    PrivateEmail = "M3hrdad.Kazemy@gmail.com",
            //    Telephone = "0487/303512"
            //};
            //employeeService.Update(employee);


            /*
            var workExperiences = this.workExperienceService.GetAll();
            var employeeTest = this.employeeService.Get(2);
            this.employeeService.Delete(3);
            
            var employee = new AbcPeople.BDO.Entities.Employee() { FirstName = "Mehrdad", LastName = "Kazemi", CreatedOn = DateTime.Now };
            employeeService.Create(employee);
            */

            //var addresses = this.addressService.GetAll();
            //var address1 = this.addressService.Get(1);

            var employee1 = this.employeeService.Get(1, x => x.Include(y => y.WorkExperiences));
            var employeesBornedThisMonth = this.employeeService.GetEmployeesBornedThisMonth();

            HomepageViewModel homepageViewModel = new HomepageViewModel()
            {
                Employees = this.employeeService.GetAll(x => x.Include(y => y.ProfileAdjustments).Include(y => y.WorkExperiences).Include(y => y.HomeAddress)),
                ProfileAdjustments = this.profileAdjustmentService.GetAll()
            };

            //var employeeUpdate = new AbcPeople.BDO.Entities.Employee() { Id = 5, FirstName = "MehrdadUpd", LastName = "KazemiUpd", CreatedOn = DateTime.Now };
            //employeeService.Update(employeeUpdate);

            return View(homepageViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
