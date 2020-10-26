﻿using AbcPeople.DAL.Entities.Base;
using System;

namespace AbcPeople.DAL.Entities
{
    public class Exam : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        //public int CompanyId { get; set; }
    }
}
