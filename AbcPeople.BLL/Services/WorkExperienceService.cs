using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AbcPeople.BLL.Services
{
    //public class WorkExperienceService : IWorkExperienceService
    //{
    //    private readonly AbcPeopleEntities context;
    //    protected readonly IMapper mapper;

    //    public WorkExperienceService(AbcPeopleEntities context, IMapper mapper)
    //    {
    //        this.context = context;
    //        this.mapper = mapper;
    //    }

    //    public IEnumerable<WorkExperience> GetAll()
    //    {
    //        try
    //        {
    //            var dalWorkExperiences = context.WorkExperiences.ToList();
    //            return mapper.Map<IEnumerable<WorkExperience>>(dalWorkExperiences);
    //        }
    //        catch (Exception ex)
    //        {
    //            return null;
    //        }
    //    }
    //}

    public class WorkExperienceService : BaseService<WorkExperience, DAL.Entities.WorkExperience>, IWorkExperienceService
    {
        public WorkExperienceService(ILogger<WorkExperienceService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {

        }

    }
}
