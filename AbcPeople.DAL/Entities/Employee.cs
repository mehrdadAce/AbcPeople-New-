using AbcPeople.DAL.Entities.Base;
using System.Collections.Generic;

namespace AbcPeople.DAL.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; } // -> om extra query te vermijden!
        //public int HomeAddressId { get; set; }
        public virtual Address HomeAddress { get; set; }
        //public int PlaceOfWorkAddressId { get; set; }
        public virtual Address PlaceOfWorkAddress { get; set; }
    }
}
