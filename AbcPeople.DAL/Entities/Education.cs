using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities
{
    public class Education : ListItemBaseEntity
    {
        public string Institution { get; set; }
        public int CityId { get; set; }
    }
}
