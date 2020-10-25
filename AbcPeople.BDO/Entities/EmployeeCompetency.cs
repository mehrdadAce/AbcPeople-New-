using AbcPeople.BDO.Entities.Base;
using System.Collections.Generic;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeCompetency : BaseEntity
    {
        public IEnumerable<Competency> Competency { get; set; }
        public Employee Employee { get; set; }
        public KnowledgeLevel KnowledgeLevel { get; set; }
    }
}
