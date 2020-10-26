using AutoMapper;

namespace AbcPeople.BLL.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BDO.Entities.Employee, DAL.Entities.Employee>().ReverseMap();
            CreateMap<BDO.Entities.WorkExperience, DAL.Entities.WorkExperience>().ReverseMap();
            CreateMap<BDO.Entities.Address, DAL.Entities.Address>().ReverseMap();
            CreateMap<BDO.Entities.City, DAL.Entities.City>().ReverseMap();
            CreateMap<BDO.Entities.ProfileAdjustment, DAL.Entities.ProfileAdjustment>().ReverseMap();
            CreateMap<BDO.Entities.Language, DAL.Entities.Language>().ReverseMap();
            CreateMap<BDO.Entities.EmployeeCompetency, DAL.Entities.EmployeeCompetency>().ReverseMap();
            CreateMap<BDO.Entities.FamilySituation, DAL.Entities.FamilySituation>().ReverseMap();
            CreateMap<BDO.Entities.EmployeeExam, DAL.Entities.EmployeeExam>().ReverseMap(); 
            CreateMap<BDO.Entities.EmployeeEducation, DAL.Entities.EmployeeEducation>().ReverseMap(); 
            CreateMap<BDO.Entities.Nationality, DAL.Entities.Nationality>().ReverseMap(); 
            CreateMap<BDO.Entities.Course, DAL.Entities.Course>().ReverseMap(); 
            CreateMap<BDO.Entities.LanguageSkill, DAL.Entities.LanguageSkill>().ReverseMap(); 
            CreateMap<BDO.Entities.Competency, DAL.Entities.Competency>().ReverseMap(); 
            CreateMap<BDO.Entities.KnowledgeLevel, DAL.Entities.KnowledgeLevel>().ReverseMap(); 
            CreateMap<BDO.Entities.Role, DAL.Entities.Role>().ReverseMap(); 
            CreateMap<BDO.Entities.EmployeeTitle, DAL.Entities.EmployeeTitle>().ReverseMap(); 
            CreateMap<BDO.Entities.SeniorityLevel, DAL.Entities.SeniorityLevel>().ReverseMap(); 
            CreateMap<BDO.Entities.Country, DAL.Entities.Country>().ReverseMap(); 
            CreateMap<BDO.Entities.Certificate, DAL.Entities.Certificate>().ReverseMap(); 
            CreateMap<BDO.Entities.EmployeeCertificate, DAL.Entities.EmployeeCertificate>().ReverseMap(); 
            CreateMap<BDO.Entities.Exam, DAL.Entities.Exam>().ReverseMap(); 
        }
    }
}
