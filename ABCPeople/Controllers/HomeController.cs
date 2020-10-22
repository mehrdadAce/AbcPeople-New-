using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABCPeople.Web.Models;
using AbcPeople.BLL.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using AbcPeople.ViewModels;
using AbcPeople.BDO.Entities;

namespace ABCPeople.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IWorkExperienceService workExperienceService;
        private readonly IAddressService addressService;
        private readonly ILogger<HomeController> _logger;
        private readonly IProfileAdjustmentService profileAdjustmentService;
        private readonly ILanguageService languageService;

        public HomeController(ILogger<HomeController> logger, 
                              IEmployeeService employeeService, 
                              IWorkExperienceService workExperienceService, 
                              IAddressService addressService,
                              IProfileAdjustmentService profileAdjustmentService,
                              ILanguageService languageService)
        {
            _logger = logger;
            this.employeeService = employeeService;
            this.workExperienceService = workExperienceService;
            this.addressService = addressService;
            this.profileAdjustmentService = profileAdjustmentService;
            this.languageService = languageService;
        }

        public IActionResult Index()
        {
            var employee1 = this.employeeService.Get(1, x => x.Include(y => y.WorkExperiences));
            var employeesBornedThisMonth = this.employeeService.GetEmployeesBornedThisMonth();

            HomepageViewModel homepageViewModel = new HomepageViewModel()
            {
                Employees = this.employeeService.GetAll(x => x.Include(y => y.ProfileAdjustments).Include(y => y.WorkExperiences).Include(y => y.HomeAddress)),
                ProfileAdjustments = this.profileAdjustmentService.GetAll()
            };

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
