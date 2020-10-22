using AbcPeople.BDO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbcPeople.ViewModels
{
    public class ProfileInfoViewModel
    {
        public Employee Employee { get; set; }
        public IEnumerable<Language> Languages { get; set; }
    }
}
