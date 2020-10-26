using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeExam : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public DateTime Date { get; set; }
    }
}
