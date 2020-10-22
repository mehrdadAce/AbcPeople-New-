using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class LanguageSkillService : BaseService<LanguageSkill, DAL.Entities.LanguageSkill>, ILanguageSkillService
    {
        public LanguageSkillService(ILogger<LanguageSkillService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
