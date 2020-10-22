using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;


namespace AbcPeople.BLL.Services
{
    public class EmployeeExamService : BaseService<EmployeeExam, DAL.Entities.EmployeeExam>, IEmployeeExamService
    {
        public EmployeeExamService(ILogger<EmployeeExamService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
