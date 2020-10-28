using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.DAL.Entities
{
    public class Exam : ListItemBaseEntity
    {
        public string Description { get; set; }
        public virtual ICollection<EmployeeExam> EmployeeExams { get; set; }
        //public int CompanyId { get; set; }
    }
}
