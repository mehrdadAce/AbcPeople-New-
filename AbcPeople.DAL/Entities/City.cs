using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class City : BaseEntity
    {
        public int Name { get; set; }
        public Address Address { get; set; }
    }
}
