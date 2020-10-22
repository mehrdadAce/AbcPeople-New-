using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeEducation : BaseEntity
    {
        public int EducationId { get; set; }
        public int EmployeeId { get; set; }
    }
}
