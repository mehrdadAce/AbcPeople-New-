using AbcPeople.BDO.Entities.Base;
using System;

namespace AbcPeople.BDO.Entities
{
    public class WorkExperience: BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
    }
}
