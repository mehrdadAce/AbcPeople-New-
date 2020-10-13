﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABCPeople.Web.Models;
using AbcPeople.BLL.Services.Interfaces;

namespace ABCPeople.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService employeeServcie;
        private readonly IWorkExperienceService workExperienceService;
        private readonly IAddressService addressService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IEmployeeService employeeService, IWorkExperienceService workExperienceService, IAddressService addressService)
        {
            _logger = logger;
            this.employeeServcie = employeeService;
            this.workExperienceService = workExperienceService;
            this.addressService = addressService;
        }

        public IActionResult Index()
        {
            var employees = this.employeeServcie.GetAll();
            var workExperiences = this.workExperienceService.GetAll();
            var employeeTest = this.employeeServcie.Get(2);
            this.employeeServcie.Delete(3); // wordt wel verwijderd van de context maar geen SaveChenges() !!! -> niet van db!

            var address = this.addressService.GetAll();

            return View(employees);
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
