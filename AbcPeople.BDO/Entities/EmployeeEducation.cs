using AbcPeople.BDO.Entities.Base;
using System;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeEducation : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int EmployeeId { get; set; }
    }
}
