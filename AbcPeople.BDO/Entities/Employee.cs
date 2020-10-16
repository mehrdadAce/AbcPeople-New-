using AbcPeople.BDO.Entities.Base;
using System.Collections.Generic;

namespace AbcPeople.BDO.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public Address HomeAddress { get; set; }
        public List<ProfileAdjustment> ProfileAdjustments { get; set; }

    }
}
