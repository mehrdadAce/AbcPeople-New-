using AbcPeople.DAL.Entities.Base;
namespace AbcPeople.DAL.Entities
{
    public class Competency : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompetencyCategoryId { get; set; }
    }
}
