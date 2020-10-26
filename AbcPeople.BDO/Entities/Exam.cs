using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.BDO.Entities
{
    public class Exam : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<EmployeeExam> EmployeeExams { get; set; }
        //public int CompanyId { get; set; }
    }
}
