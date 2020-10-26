using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeExam : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int ExamId { get; set; }
        public DateTime Date { get; set; }
    }
}
