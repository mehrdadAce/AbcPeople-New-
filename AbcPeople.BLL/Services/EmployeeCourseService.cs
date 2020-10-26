using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AbcPeople.BLL.Services
{
    public class EmployeeCourseService : BaseService<EmployeeCourse, DAL.Entities.EmployeeCourse>, IEmployeeCourseService
    {
        public EmployeeCourseService(ILogger<EmployeeCourseService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
