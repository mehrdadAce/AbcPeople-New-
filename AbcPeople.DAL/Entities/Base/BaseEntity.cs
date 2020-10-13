using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }
        public void Delete()
        {
            DeletedOn = DateTime.Now;
        }
    }
}
