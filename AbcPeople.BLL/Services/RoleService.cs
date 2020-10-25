using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class RoleService : BaseService<Role, DAL.Entities.Role>, IRoleService
    {
        public RoleService(ILogger<RoleService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }

}
