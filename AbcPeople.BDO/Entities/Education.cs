using AbcPeople.BDO.Entities.Base;
using System.Collections.Generic;

namespace AbcPeople.BDO.Entities
{
    public class Education: ListItemBaseEntity
    {
        public string Institution { get; set; }
        public int CityId { get; set; }
        public List<EmployeeEducation> EmployeeEducations { get; set; }
    }
}
