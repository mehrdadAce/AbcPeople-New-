using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class SeniorityLevelService : BaseService<SeniorityLevel, DAL.Entities.SeniorityLevel>, ISeniorityLevelService
    {
        public SeniorityLevelService(ILogger<SeniorityLevelService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
