using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}