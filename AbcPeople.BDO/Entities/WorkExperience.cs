using AbcPeople.BDO.Entities.Base;
using System;

namespace AbcPeople.BDO.Entities
{
    public class WorkExperience: BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescriptionEn { get; set; }
        public string ProjectDescriptionNl { get; set; }
        public Role Role { get; set; }

    }
}
