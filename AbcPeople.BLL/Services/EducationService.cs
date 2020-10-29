using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class EducationService : BaseService<Education, DAL.Entities.Education>, IEducationService
    {
        public EducationService(ILogger<EducationService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
