using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class SeniorityLevel : BaseEntity
    {
        public string Level { get; set; }
        public string Description { get; set; }
    }
}
