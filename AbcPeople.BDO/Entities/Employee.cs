using AbcPeople.BDO.Entities.Base;

namespace AbcPeople.BDO.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? HomeAddressId { get; set; }

    }
}
