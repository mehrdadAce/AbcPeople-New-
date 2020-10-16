using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABCPeople.Web.Models;
using AbcPeople.BLL.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            /*
            var employee = new AbcPeople.BDO.Entities.Employee() {
                FirstName = "Tina",
                LastName = "Kotch",
                CreatedOn = DateTime.Now,
                HomeAddress = new AbcPeople.BDO.Entities.Address()
                {
                    StreetName = "Violet",
                    HouseNumber = "7",
                    Postalcode = "1210",
                    City = "St j ten noode",
                    Country = "Belgium"
                },
                WorkExperiences = new List<WorkExperience>()
                {
                    new WorkExperience()
                    {
                        StartDate = new DateTime(2016, 02, 05),
                        EndDate = new DateTime(2018, 10, 21),
                        CompanyName = "IBM"
                    },
                    new WorkExperience()
                    {
                        StartDate = new DateTime(2019, 01, 15),
                        EndDate = new DateTime(2019, 10, 28),
                        CompanyName = "Intel"
                    }
                },
                ProfileAdjustments = new List<ProfileAdjustment>()
                {
                    new ProfileAdjustment()
                    {
                        Timestamp = new DateTime(2017, 05, 05)
                    },
                    new ProfileAdjustment()
                    {
                        Timestamp = new DateTime(2018, 06, 06)
                    },
                    new ProfileAdjustment()
                    {
                        Timestamp = new DateTime(2020, 01, 10)
                    }
                }
            };
            employeeService.Create(employee);
            */
            // var employees = this.employeeService.GetAll();

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
            var allProfileAdjustments = this.profileAdjustmentService.GetAll();


            //var employeeUpdate = new AbcPeople.BDO.Entities.Employee() { Id = 5, FirstName = "MehrdadUpd", LastName = "KazemiUpd", CreatedOn = DateTime.Now };
            //employeeService.Update(employeeUpdate);

            return View();
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
