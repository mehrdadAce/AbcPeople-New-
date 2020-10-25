using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class CompetencyService : BaseService<Competency, DAL.Entities.Competency>, ICompetencyService
    {
        public CompetencyService(ILogger<CompetencyService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
