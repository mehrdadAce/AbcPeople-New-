using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.DAL.Entities
{
    public class Certificate : ListItemBaseEntity  // koppeltabel
    {
        public string Description { get; set; }
        //public int CompanyId { get; set; }  // todo
        public virtual ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }
    }
}
