using AbcPeople.DAL.Entities.Base;
using System.Collections.Generic;

namespace AbcPeople.DAL.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
        public int? HomeAddressId { get; set; }
        public virtual Address HomeAddress { get; set; }
        public virtual ICollection<ProfileAdjustment> ProfileAdjustments { get; set; }
    }
}
