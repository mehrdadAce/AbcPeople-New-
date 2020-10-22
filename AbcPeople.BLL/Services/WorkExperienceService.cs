using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class WorkExperienceService : BaseService<WorkExperience, DAL.Entities.WorkExperience>, IWorkExperienceService
    {
        public WorkExperienceService(ILogger<WorkExperienceService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {

        }
    }
}
