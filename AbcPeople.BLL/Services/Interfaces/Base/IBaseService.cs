
using AbcPeople.BDO.Entities.Base;
using System.Collections.Generic;

namespace AbcPeople.BLL.Services.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Delete(int id);
        void Create(T obj);
        void Update(T obj);
    }
}
