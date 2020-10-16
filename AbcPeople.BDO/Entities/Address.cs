using AbcPeople.BDO.Entities.Base;

namespace AbcPeople.BDO.Entities
{
    public class Address : BaseEntity
    {
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //public int EmployeeId { get; set; }
    }
}
