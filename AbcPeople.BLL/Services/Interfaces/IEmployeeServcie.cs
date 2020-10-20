using AbcPeople.BDO.Entities;
using System.Collections.Generic;

namespace AbcPeople.BLL.Services.Interfaces
{
    public interface IEmployeeService: IBaseService<Employee, DAL.Entities.Employee> 
    {
        IEnumerable<Employee> GetEmployeesBornedThisMonth();
    }
}
