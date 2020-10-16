using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class ProfileAdjustment : BaseEntity
    {
        public DateTime Timestamp { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
