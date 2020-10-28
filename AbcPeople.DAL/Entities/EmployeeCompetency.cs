using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeCompetency : BaseEntity
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int CompetencyId { get; set; }
        public IEnumerable<Competency> Competency { get; set; } // todo : 1 competencie -> collection verwijderen
        public int KnowledgeLevelId { get; set; }
        public KnowledgeLevel Level { get; set; }
    }
}
