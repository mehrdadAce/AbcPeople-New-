using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using log4net;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcPeople.BLL.Services
{
    public class EmployeeService : BaseService<Employee, DAL.Entities.Employee>, IEmployeeService
    {
        //private readonly ILog log;
        //private readonly AbcPeopleEntities context;
        //protected readonly IMapper mapper;

        //public EmployeeService(AbcPeopleEntities context, IMapper mapper)
        //{
        //    this.context = context;
        //    this.mapper = mapper;
        //}

        //public IEnumerable<Employee> GetAll()
        //{
        //    try  // als er een probleem is met de db -> gebruik dan een try-catch
        //    {
        //        //log.Debug("Getting all employees");

        //        var dalEmployees = context.Employees.ToList();
        //        return mapper.Map<IEnumerable<Employee>>(dalEmployees);
        //    }
        //    catch (Exception ex)
        //    {
        //        //log.Error("Error while getting all employees", ex);
        //        return null;
        //    }
        //}

        public EmployeeService(ILogger<EmployeeService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
