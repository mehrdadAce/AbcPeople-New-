using System.Collections.Generic;
using AbcPeople.BDO.Entities;

namespace AbcPeople.ViewModels
{
    public class HomepageViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<ProfileAdjustment> ProfileAdjustments { get; set; }
    }
}
