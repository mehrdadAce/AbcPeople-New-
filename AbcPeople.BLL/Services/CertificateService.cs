using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;


namespace AbcPeople.BLL.Services
{
    public class CertificateService : BaseService<Certificate, DAL.Entities.Certificate>, ICertificateService
    {
        public CertificateService(ILogger<CertificateService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
