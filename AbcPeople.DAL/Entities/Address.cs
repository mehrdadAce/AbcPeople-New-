﻿using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class Address : BaseEntity
    {
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string Postcode { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        //public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }  // virtal -> lazy loading!

        // TODO - compare with employee !!! 
    }
}
