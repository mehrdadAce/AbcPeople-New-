using AbcPeople.BDO.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AbcPeople.ViewModels
{
    public class ProfileEducationAddExamViewModel
    {
        public EmployeeExam EmployeeExam { get; set; }
        public List<SelectListItem> Exams { get; set; }
    }
}
