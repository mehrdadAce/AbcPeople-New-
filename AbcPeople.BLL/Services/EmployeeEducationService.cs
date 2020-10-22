using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class EmployeeEducationService : BaseService<EmployeeEducation, DAL.Entities.EmployeeEducation>, IEmployeeEducationService
    {
        public EmployeeEducationService(ILogger<EmployeeEducationService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
