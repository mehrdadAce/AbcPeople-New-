using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeCertificate : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int CertificateId { get; set; }
    }
}
