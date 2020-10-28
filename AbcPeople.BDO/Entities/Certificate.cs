using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.BDO.Entities
{
    public class Certificate : ListItemBaseEntity
    {
        public string Description { get; set; }
        //public int CompanyId { get; set; }
        public virtual ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }
    }
}
