using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcPeople.BLL.Services
{
    public class ProfileAdjustmentService : BaseService<ProfileAdjustment, DAL.Entities.ProfileAdjustment>, IProfileAdjustmentService
    {
        public ProfileAdjustmentService(ILogger<ProfileAdjustmentService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }

        public IEnumerable<ProfileAdjustment> GetLastProfileAdjustments(Func<IQueryable<DAL.Entities.ProfileAdjustment>, IQueryable<DAL.Entities.ProfileAdjustment>> dbSetFunc = null)
        {
            try
            {
                log.LogError($"Getting last profile adjustments");
                var entities = dbSet as IQueryable<DAL.Entities.ProfileAdjustment>;

                if (dbSetFunc != null)
                    entities = dbSetFunc(dbSet);
                var lastAdjustments = entities.AsEnumerable()
                                           .OrderByDescending(y => y.Timestamp)
                                           .GroupBy(y => y.EmployeeId)
                                           .Select(y => y.First())
                                           .Take(5)
                                           .ToList();
                return mapper.Map<IEnumerable<ProfileAdjustment>>(lastAdjustments);
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return null;
            }
        }

    }
}
