using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.DAL.Entities
{
    public class Certificate : BaseEntity  // koppeltabel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //public int CompanyId { get; set; }
        public virtual ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }

    }
}
