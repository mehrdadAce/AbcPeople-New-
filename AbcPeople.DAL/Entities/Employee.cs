using AbcPeople.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.DAL.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string PrivateEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; } //todo : enum -> int in db!
        public DateTime BeginDateOfWork { get; set; }
        public int? EmployeeTitleId { get; set; } // todo
        public EmployeeTitle EmployeeTitle { get; set; }
        public string Coach { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public string ShortDescriptionNL { get; set; }
        public string ShortDescriptionEN { get; set; }
        public string Hobbys { get; set; }
        public int FamilySituationId { get; set; }
        public FamilySituation FamilySituation { get; set; }
        public IEnumerable<LanguageSkill> LanguageSkills { get; set; }
        public IEnumerable<EmployeeCompetency> EmployeeCompetencies { get; set; }
        public int? MotherLanguageId { get; set; }
        public Language MotherLanguage { get; set; }
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
        public int HomeAddressId { get; set; }
        public virtual Address HomeAddress { get; set; }
        public virtual ICollection<ProfileAdjustment> ProfileAdjustments { get; set; }
        public string Gsm { get; set; }
        public virtual ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }
        public virtual ICollection<EmployeeExam> EmployeeExams { get; set; }
        public virtual ICollection<EmployeeCourse> EmployeeCourses { get; set; }
        public int SocialNetworkId { get; set; }
        public SocialNetwork SocialNetwork { get; set; }
    }
}
