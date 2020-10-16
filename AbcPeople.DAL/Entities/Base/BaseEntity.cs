using System;

namespace AbcPeople.DAL.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public BaseEntity()
        {
            //todo test of deze overschreven wordt
            CreatedOn = DateTime.Now;
        }
        public void Delete()
        {
            DeletedOn = DateTime.Now;
        }
    }
}
