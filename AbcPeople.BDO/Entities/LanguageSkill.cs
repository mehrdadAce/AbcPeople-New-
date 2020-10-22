using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.BDO.Entities
{
    public class LanguageSkill : BaseEntity
    {
        public int ReadLevel { get; set; }
        public int WriteLevel { get; set; }
        public int SpeakLevel { get; set; }
        public int EmployeeId { get; set; }
        public int LanguageId { get; set; }
    }
}
