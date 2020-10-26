using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class EmployeeCertificateService : BaseService<EmployeeCertificate, DAL.Entities.EmployeeCertificate>, IEmployeeCertificateService
    {
        public EmployeeCertificateService(ILogger<EmployeeCertificateService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
