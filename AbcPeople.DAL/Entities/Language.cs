﻿using AbcPeople.DAL.Entities.Base;

namespace AbcPeople.DAL.Entities
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
    }
}