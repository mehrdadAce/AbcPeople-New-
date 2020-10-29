using AbcPeople.BDO.Entities.Base;

namespace AbcPeople.BDO.Entities
{
    public class Education: ListItemBaseEntity
    {
        public string Institution { get; set; }
        public int CityId { get; set; }
    }
}
