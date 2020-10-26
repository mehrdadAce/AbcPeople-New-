using AbcPeople.DAL.Entities.Base;
using System;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeCertificate : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public DateTime Date { get; set; }
    }
}
