using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class EmployeeTitle : BaseEntity
    {
        public string Title { get; set; }
        public string Domain { get; set; }
        public int? SeniorityLevelId { get; set; }
        public SeniorityLevel SeniorityLevel { get; set; }
    }
}
