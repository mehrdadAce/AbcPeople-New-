using AbcPeople.BDO.Entities.Base;
using System;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeCertificate : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public DateTime Date { get; set; }
    }
}
