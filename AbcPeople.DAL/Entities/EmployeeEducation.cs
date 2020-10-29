using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
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
