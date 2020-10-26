using AbcPeople.BDO.Entities.Base;

namespace AbcPeople.BDO.Entities
{
    public class EmployeeTitle : BaseEntity
    {
        public string Title { get; set; }
        public string Domain { get; set; }
        public SeniorityLevel SeniorityLevel { get; set; }
    }
}
