using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcPeople.BLL.Services
{
    public class EmployeeService : BaseService<Employee, DAL.Entities.Employee>, IEmployeeService
    {
        public EmployeeService(ILogger<EmployeeService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }

        public IEnumerable<Employee> GetEmployeesBornedThisMonth()
        {
            try
            {
                return mapper.Map<IEnumerable<Employee>>(this.context.Employees.Where(e => e.DateOfBirth.Month == DateTime.Now.Month).ToList());
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"Error while Fetching {typeof(DAL.Entities.Employee)}'s");
                return null;
            }
        }

        protected override void UpdateProperties(Employee entity, DAL.Entities.Employee dalEntity)
        {
            //dalEntity.WorkExperiences = ; // foreach !
            //foreach (var item in entity.WorkExperiences)
            //{
            //}

            dalEntity.FirstName = entity.FirstName ?? dalEntity.FirstName;
            dalEntity.LastName = entity.LastName ?? dalEntity.LastName;
            dalEntity.Email = entity.Email ?? dalEntity.Email;
            dalEntity.Telephone = entity.Telephone ?? dalEntity.Telephone;
            dalEntity.PrivateEmail = entity.PrivateEmail ?? dalEntity.PrivateEmail;
            dalEntity.DateOfBirth = entity.DateOfBirth == default ?  dalEntity.DateOfBirth : entity.DateOfBirth;
            dalEntity.Gender = entity.Gender == default(char) ? dalEntity.Gender : entity.Gender;
            dalEntity.BeginDateOfWork = entity.BeginDateOfWork == default ? dalEntity.BeginDateOfWork : entity.BeginDateOfWork;
            dalEntity.EmployeeTitle = entity.EmployeeTitle ?? dalEntity.EmployeeTitle;
            dalEntity.Coach = entity.Coach ?? dalEntity.Coach;
            //public Address PlaceOfWorkAddress { get; set; }
            dalEntity.Nationality = entity.Nationality ?? dalEntity.Nationality;
            dalEntity.FamilySituation = entity.FamilySituation ?? dalEntity.FamilySituation;
            dalEntity.MotherLanguage = entity.MotherLanguage != null ? mapper.Map<DAL.Entities.Language>(entity.MotherLanguage) : dalEntity.MotherLanguage;
            dalEntity.ShortDescriptionNL = entity.ShortDescriptionNL ?? dalEntity.ShortDescriptionNL;
            dalEntity.ShortDescriptionEN = entity.ShortDescriptionEN ?? dalEntity.ShortDescriptionEN;
            dalEntity.Hobbys = entity.Hobbys ?? dalEntity.Hobbys;

            context.ProfileAdjustments.Add(new DAL.Entities.ProfileAdjustment()
            {
                EmployeeId = entity.Id,
                Timestamp = DateTime.Now
            });
        }

        //public Employee FindEmployeeInContext
    }
}
