using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class ProfileAdjustmentService : BaseService<ProfileAdjustment, DAL.Entities.ProfileAdjustment>, IProfileAdjustmentService
    {
        public ProfileAdjustmentService(ILogger<ProfileAdjustmentService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
