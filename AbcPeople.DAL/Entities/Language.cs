using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
    }
}
