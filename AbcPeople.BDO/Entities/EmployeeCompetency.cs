using AbcPeople.BDO.Entities.Base;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeCompetency : BaseEntity
    {
        public int CompetencyId { get; set; }
        public int EmployeeId { get; set; }
        public int KnowledgeLevelId { get; set; }
    }
}
