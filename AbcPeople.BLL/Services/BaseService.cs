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
                log.LogDebug($"Getting all {typeof(TDal)}");
                var list = context.Set<TDal>().ToList();
                return mapper.Map<IEnumerable<T>>(list);
            }
            catch (Exception ex)
            {
                log.LogDebug(ex.Message);
                return null;
            }
        }

        public T Get(int id)
        {
            try
            {
                log.LogDebug($"Getting {typeof(TDal)} {id}");
                var obj = context.Set<TDal>().Where(x => x.Id == id).FirstOrDefault();
                return mapper.Map<T>(obj);
            }
            catch (Exception ex)
            {
                log.LogDebug(ex.Message);
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {
                log.LogDebug($"Deleting {typeof(TDal)} {id}");
                var entityToRemove = context.Set<TDal>().Where(x => x.Id == id).FirstOrDefault();
                if (entityToRemove == null)
                {
                    return;
                }
                context.Set<TDal>().Remove(entityToRemove);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                log.LogDebug(ex.Message);
                throw;
            }
        }

        public void Create(T obj)
        {
            try
            {
                log.LogDebug($"Creating new BDO object");
                var newObj = context.Add(mapper.Map<TDal>(obj));
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                log.LogDebug(ex.Message);
                throw;
            }
        }

        public void Update(T obj)
        {
            try
            {
                log.LogDebug($"Updating BDO object");
                //var foundEntity = context.Set<TDal>().Where(x => x.Id == obj.Id).FirstOrDefault();
                //if(foundEntity != null)
                //{
                    
                //}

                context.Update(mapper.Map<TDal>(obj));
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                log.LogDebug(ex.Message);
                throw;
            }
        }
    }
}
