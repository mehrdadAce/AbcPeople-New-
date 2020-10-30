using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class Course : ListItemBaseEntity
    {
        public string Description { get; set; }
        public string Location { get; set; }
    }
}
