using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class FamilySituationService : BaseService<FamilySituation, DAL.Entities.FamilySituation>, IFamilySituationService
    {
        public FamilySituationService(ILogger<FamilySituationService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }

}
