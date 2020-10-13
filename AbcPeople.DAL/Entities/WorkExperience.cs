using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class WorkExperience: BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }  // virtal -> lazy loading!
    }
}
