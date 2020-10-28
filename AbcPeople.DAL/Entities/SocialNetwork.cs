using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class SocialNetwork : BaseEntity
    {
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string Blog { get; set; }
    }
}
