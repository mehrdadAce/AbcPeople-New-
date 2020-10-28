using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class SocialNetworkService : BaseService<SocialNetwork, DAL.Entities.SocialNetwork>, ISocialNetworkService
    {
        public SocialNetworkService(ILogger<SocialNetworkService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
