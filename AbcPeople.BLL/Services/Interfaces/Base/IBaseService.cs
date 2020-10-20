
using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcPeople.BLL.Services.Interfaces
{
    public interface IBaseService<T, TDal> where T : BaseEntity where TDal : DAL.Entities.Base.BaseEntity
    {
        IEnumerable<T> GetAll(Func<IQueryable<TDal>, IQueryable<TDal>> dbSetFunc = null); 
        T Get(int id, Func<IQueryable<TDal>, IQueryable<TDal>> dbSetFunc = null);
        bool Delete(int id);
        bool Create(T obj);
        bool Update(T obj, Func<IQueryable<TDal>, IQueryable<TDal>> dbSetFunc = null);
    }
}
