using AbcPeople.DAL.Entities.Base;
namespace AbcPeople.DAL.Entities
{
    public class LanguageSkill : BaseEntity
    {
        public int ReadLevel { get; set; }
        public int WriteLevel { get; set; }
        public int SpeakLevel { get; set; }
        public int EmployeeId { get; set; }
        //public int LanguageId { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
