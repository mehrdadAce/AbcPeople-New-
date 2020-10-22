using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services;
using AbcPeople.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var currentEmployee = this.employeeService.Get(4, x => x.Include(y => y.ProfileAdjustments));
            return View(currentEmployee);
        }

        public IActionResult ProfileInfoEdit() // ProfileInfoEdit - EditProfileUser
        {
            Employee currentUser = this.employeeService.Get(4, x => x.Include(y => y.HomeAddress));   // ?????????????????
            return View("ProfileInfoEdit", currentUser);
        }

        [HttpPost]
        public IActionResult SaveEditProfileUser(int id, [Bind("Id, FirstName, LastName, HomeAddress, Email, Telephone, PlaceOfWorkAddress, PrivateEmail, DateOfBirth, Gender, FamilySituation, MotherLanguage, Nationality, BeginDateOfWork, ShortDescriptionNL, ShortDescriptionEN, Hobbys")] Employee employee)
        {
            //this.employeeService.Update(employee);
            this.employeeService.Update(employee);
            return View("ProfileInfo", employee);
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
