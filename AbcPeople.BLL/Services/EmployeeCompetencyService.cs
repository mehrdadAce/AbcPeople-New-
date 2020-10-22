using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class EmployeeCompetencyService : BaseService<EmployeeCompetency, DAL.Entities.EmployeeCompetency>, IEmployeeCompetencyService
    {
        public EmployeeCompetencyService(ILogger<EmployeeCompetencyService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }

}
