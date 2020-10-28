﻿using AbcPeople.BDO.Entities;
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

        public IEnumerable<Employee> GetUpcomingBirthdays()
        {
            try
            {
                var testa = dbSet.Where(e => e.DateOfBirth.Month > DateTime.Now.Month && e.DateOfBirth.Day > DateTime.Now.Day).ToList();

                var test = dbSet.Where(e => e.DateOfBirth.Month > DateTime.Now.Month && e.DateOfBirth.Day > DateTime.Now.Day)
                    .OrderByDescending(e => e.DateOfBirth.Month).OrderByDescending(e => e.DateOfBirth.Day)
                    .ToList();

                //var test2 = dbSet.Where(e => e.DateOfBirthDateTime.Now.Month && e.DateOfBirth.Day >= DateTime.Now.Day)
                //  .OrderByDescending(e => e.DateOfBirth)
                //  .ToList();

                return mapper.Map<IEnumerable<Employee>>(dbSet.Where(e => e.DateOfBirth.Month >= DateTime.Now.Month && e.DateOfBirth.Day >= DateTime.Now.Day).OrderByDescending(e => e.DateOfBirth).ToList());
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"Error while Fetching {typeof(DAL.Entities.Employee)}'s");
                return null;
            }
        }

        protected override void UpdateProperties(Employee entity, DAL.Entities.Employee dalEntity)
        {
            dalEntity.FirstName = entity.FirstName;
            dalEntity.LastName = entity.LastName;
            dalEntity.Email = entity.Email;
            dalEntity.Telephone = entity.Telephone;
            dalEntity.PrivateEmail = entity.PrivateEmail;
            dalEntity.DateOfBirth = entity.DateOfBirth;
            dalEntity.Gender = entity.Gender;
            dalEntity.BeginDateOfWork = entity.BeginDateOfWork;
            //dalEntity.EmployeeTitle = entity.EmployeeTitle ?? dalEntity.EmployeeTitle;
            dalEntity.Coach = entity.Coach;

            if (entity.HomeAddress != null)
            {
                dalEntity.HomeAddress.StreetName = entity.HomeAddress.StreetName;
                dalEntity.HomeAddress.HouseNumber = entity.HomeAddress.HouseNumber;
                dalEntity.HomeAddress.CityId = entity.HomeAddress.CityId;
                dalEntity.HomeAddress.Postalcode = entity.HomeAddress.Postalcode;
                dalEntity.HomeAddress.CountryId = entity.HomeAddress.CountryId == 0 ?  1 : entity.HomeAddress.CountryId;
            }

            //dalEntity.NationalityId = entity.NationalityId != null ? entity.NationalityId : dalEntity.NationalityId;
            //dalEntity.FamilySituationId = entity.FamilySituationId != null ? entity.FamilySituationId : dalEntity.FamilySituationId;
            //dalEntity.MotherLanguageId = entity.MotherLanguageId != null ? entity.MotherLanguageId : dalEntity.MotherLanguageId;
            //dalEntity.RoleId = entity.Role != null ? entity.RoleId : dalEntity.RoleId;

            dalEntity.ShortDescriptionNL = entity.ShortDescriptionNL;
            dalEntity.ShortDescriptionEN = entity.ShortDescriptionEN;
            dalEntity.Hobbys = entity.Hobbys;

            context.ProfileAdjustments.Add(new DAL.Entities.ProfileAdjustment()
            {
                EmployeeId = entity.Id,
                Timestamp = DateTime.Now
            });
        }
    }
}
