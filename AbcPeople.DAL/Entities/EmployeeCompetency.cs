using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeCompetency : BaseEntity
    {
        public int CompetencyId { get; set; }
        public int EmployeeId { get; set; }
        public int KnowledgeLevelId { get; set; }
    }
}
