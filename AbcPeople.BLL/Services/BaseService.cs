using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace AbcPeople.BLL.Services
{
    public class BaseService<T, TDal> : IBaseService<T> where T : BaseEntity where TDal : DAL.Entities.Base.BaseEntity
    {
        private readonly ILogger<BaseService<T, TDal>> log;
        private readonly AbcPeopleEntities context;
        protected readonly IMapper mapper;
        public BaseService(ILogger<BaseService<T, TDal>> log, AbcPeopleEntities context, IMapper mapper)
        {
            this.log = log;
            this.context = context;
            this.mapper = mapper;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                log.LogDebug("Getting all employees");
                var list = context.Set<TDal>().ToList();
                return mapper.Map<IEnumerable<T>>(list);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public T Get(int id)
        {
            try
            {
                log.LogDebug($"Getting employee {id}");
                var obj = context.Set<TDal>().Where(x => x.Id == id).FirstOrDefault();
                return mapper.Map<T>(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {
                log.LogDebug($"Deleting employee {id}");
                var entityToRemove = context.Set<TDal>().Where(x => x.Id == id).FirstOrDefault();
                context.Set<TDal>().Remove(entityToRemove);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T Create()
        {
            try
            {
                log.LogDebug($"Creating new BDO object");
                //T newObj = new T();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Update(T obj)
        {
            try
            {
                log.LogDebug($"Updating BDO object");
                var entity = context.Set<TDal>().First(x => x.Id == obj.Id);
                entity = mapper.Map<TDal>(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
