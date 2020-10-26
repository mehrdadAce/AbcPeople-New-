using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class CountryService : BaseService<Country, DAL.Entities.Country>, ICountryService
    {
        public CountryService(ILogger<CountryService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
