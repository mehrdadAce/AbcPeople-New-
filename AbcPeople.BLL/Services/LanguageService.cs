using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class LanguageService : BaseService<Language, DAL.Entities.Language>, ILanguageService
    {
        public LanguageService(ILogger<LanguageService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {

        }
    }
}
