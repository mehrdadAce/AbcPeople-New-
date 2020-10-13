using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.BDO.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
