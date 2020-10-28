using AbcPeople.BDO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcPeople.BLL.Services.Interfaces
{
    public interface IProfileAdjustmentService : IBaseService<ProfileAdjustment, DAL.Entities.ProfileAdjustment>
    {
        IEnumerable<ProfileAdjustment> GetLastProfileAdjustments(Func<IQueryable<DAL.Entities.ProfileAdjustment>, IQueryable<DAL.Entities.ProfileAdjustment>> dbSetFunc = null);
    }
}
