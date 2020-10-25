using AbcPeople.BDO.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AbcPeople.ViewModels
{
    public class ProfileInfoViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Languages { get; set; }
        public string LanguageId { get; set; }
        public List<SelectListItem> Nationalities { get; set; }
        public string NationalityId { get; set; }

        public ProfileInfoViewModel()
        {

        }
        
    }
}
