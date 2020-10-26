using AbcPeople.BDO.Entities.Base;
using System;
using System.Collections.Generic;

namespace AbcPeople.BDO.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string PrivateEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public DateTime BeginDateOfWork { get; set; }
        public EmployeeTitle EmployeeTitle { get; set; }
        public string Coach { get; set; }
        //public Address PlaceOfWorkAddress { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public int? NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public string ShortDescriptionNL { get; set; }
        public string ShortDescriptionEN { get; set; }
        public string Hobbys { get; set; }
        public int? FamilySituationId { get; set; }
        public FamilySituation FamilySituation { get; set; }
        public IEnumerable<EmployeeCompetency> EmployeeCompetency { get; set; }
        public int? MotherLanguageId { get; set; }
        public Language MotherLanguage { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public Address HomeAddress { get; set; }
        public Address PlaceOfWorkAddress { get; set; }
        public List<ProfileAdjustment> ProfileAdjustments { get; set; }
        public int? Gsm { get; set; }
        public List<EmployeeExam> EmployeeExams { get; set; }
        public ICollection<EmployeeCertificate> EmployeeCertificates { get; set; }
    }
}
