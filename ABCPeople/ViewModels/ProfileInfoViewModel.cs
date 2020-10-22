using AbcPeople.BDO.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AbcPeople.ViewModels
{
    public class ProfileInfoViewModel
    {
        public Employee Employee { get; set; }

        public ProfileInfoViewModel()
        {

        }
        public List<SelectListItem> Languages { get; set; } 
    }
}
