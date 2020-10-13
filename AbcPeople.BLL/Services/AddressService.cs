using AbcPeople.BDO.Entities;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using AutoMapper;
using log4net;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcPeople.BLL.Services
{
    public class AddressService : BaseService<Address, DAL.Entities.Employee>, IAddressService
    {
        public AddressService(ILogger<AddressService> log, AbcPeopleEntities context, IMapper mapper) : base(log, context, mapper)
        {
        }
    }
}
