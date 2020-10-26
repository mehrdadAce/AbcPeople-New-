using AbcPeople.BDO.Entities.Base;
using System;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeCourse : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
