using AbcPeople.BDO.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbcPeople.ViewModels
{
    public class ProfileWorkExperienceEditViewModel
    {
        public WorkExperience WorkExperience { get; set; }
        public List<SelectListItem> Roles { get; set; }
        public List<SelectListItem> Sectores { get; set; }
    }
}
