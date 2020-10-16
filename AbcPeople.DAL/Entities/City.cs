using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class City : BaseEntity
    {
        public int Name { get; set; }
        public Address Address { get; set; }
    }
}
