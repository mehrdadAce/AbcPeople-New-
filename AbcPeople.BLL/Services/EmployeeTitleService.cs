using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class EmployeeTitleService : BaseService<EmployeeTitle, DAL.Entities.EmployeeTitle>, IEmployeeTitleService
    {
        public EmployeeTitleService(ILogger<EmployeeTitleService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
