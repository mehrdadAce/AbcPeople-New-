using AbcPeople.DAL.Entities.Base;
using System;

namespace AbcPeople.DAL.Entities
{
    public class WorkExperience: BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
        public string ProjectName { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        //public int PlaceOfWorkAddressId { get; set; }
        //public virtual Address PlaceOfWorkAddress { get; set; }
        public Role Role { get; set; }
        public string ProjectDescriptionEn { get; set; }
        public string ProjectDescriptionNl { get; set; }
    }
}
