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

        }
    }
}
