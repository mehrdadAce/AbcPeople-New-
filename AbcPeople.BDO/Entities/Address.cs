using AbcPeople.BDO.Entities.Base;

namespace AbcPeople.BDO.Entities
{
    public class Address : BaseEntity
    {
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string Postcode { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        //public int EmployeeId { get; set; }
    }
}
