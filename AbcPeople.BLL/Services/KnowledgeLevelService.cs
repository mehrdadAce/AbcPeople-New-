using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class KnowledgeLevelService : BaseService<KnowledgeLevel, DAL.Entities.KnowledgeLevel>, IKnowledgeLevelService
    {
        public KnowledgeLevelService(ILogger<KnowledgeLevelService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
