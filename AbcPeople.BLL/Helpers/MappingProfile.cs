using AbcPeople.BDO.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.BLL.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BDO.Entities.Employee, DAL.Entities.Employee>().ReverseMap();
            //CreateMap<DAL.Entities.Employee, Employee>() -> gebruik reverse , makkelijker!!
            CreateMap<BDO.Entities.WorkExperience, DAL.Entities.WorkExperience>().ReverseMap();
            CreateMap<BDO.Entities.Address, DAL.Entities.Address>().ReverseMap();
        }
    }
}
