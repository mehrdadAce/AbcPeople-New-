using AbcPeople.BDO.Entities.Base;
using System;

namespace AbcPeople.BDO.Entities
{
    public class ProfileAdjustment : BaseEntity
    {
        public DateTime Timestamp { get; set; }
        public int EmployeeId { get; set; }
    }
}
