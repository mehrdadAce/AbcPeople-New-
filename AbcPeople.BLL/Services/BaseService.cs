using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AbcPeople.BLL.Services
{
    public class BaseService<T, TDal> : IBaseService<T, TDal> where T : BaseEntity where TDal : DAL.Entities.Base.BaseEntity
    {
        protected readonly ILogger<BaseService<T, TDal>> log;
        protected readonly AbcPeopleEntities context;
        protected readonly IMapper mapper;
        protected readonly DbSet<TDal> dbSet;
        public BaseService(ILogger<BaseService<T, TDal>> log, AbcPeopleEntities context, IMapper mapper)
        {
            this.log = log;
            this.context = context;
            this.mapper = mapper;
            this.dbSet = context.Set<TDal>();
        }

        public IEnumerable<T> GetAll(Func<IQueryable<TDal>, IQueryable<TDal>> dbSetFunc = null)
        {
            try
            {
                log.LogError($"Getting all {typeof(TDal)}");
                var entities = dbSet as IQueryable<TDal>;

                if (dbSetFunc != null)
                    entities = dbSetFunc(dbSet);

                return mapper.Map<IEnumerable<T>>(entities);
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }

        public T Get(int id, Func<IQueryable<TDal>, IQueryable<TDal>> dbSetFunc = null)
        {
            try
            {
                log.LogDebug($"Getting {typeof(TDal)} {id}");
                var entities = dbSet as IQueryable<TDal>; 

                if (dbSetFunc != null)
                    entities = dbSetFunc(dbSet);

                var obj = entities.FirstOrDefault(x => x.Id == id);
                string test = "sdsfd";
                return mapper.Map<T>(obj);
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                log.LogDebug($"Deleting {typeof(TDal)} {id}");
                
                var entityToRemove = dbSet.FirstOrDefault(x => x.Id == id);
                if (entityToRemove == null)
                    return false;

                entityToRemove.Delete();
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"Error while deleting {typeof(TDal)} (id={id})");
                return false;
            }
        }

        public bool Create(T obj)
        {
            try
            {
                log.LogDebug($"Creating new BDO object");
                obj.CreatedOn = DateTime.Now;
                context.Add(mapper.Map<TDal>(obj));
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                log.LogError(ex, "Error while creating new object");
                return false;
            }
        }

        public virtual bool Update(T entity, Func<IQueryable<TDal>, IQueryable<TDal>> dbSetFunc = null)
        {
            try
            {
                log.LogDebug($"Updating BDO object");
                var entities = dbSet as IQueryable<TDal>;

                if (dbSetFunc != null)
                    entities = dbSetFunc(dbSet);

                var dalEntity = entities.FirstOrDefault(x => x.Id == entity.Id);
                UpdateProperties(entity, dalEntity);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"Error while updating {typeof(TDal)} (id={entity.Id})");
                return false;
            }
        }

        protected virtual void UpdateProperties(T entity, TDal dalEntity)
        {
            mapper.Map(entity, dalEntity);
        }
    }
}
