using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
