using AbcPeople.BLL.Services;
using AbcPeople.BLL.Services.Interfaces;
using AbcPeople.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AbcPeople.BLL.Helpers
{
    public static class ServicesConfiguration
    {
        public static void Configure (IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AbcPeopleEntities>(
                options => options.UseSqlServer(configuration.GetConnectionString("AbcPeople"))
                ); 

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IWorkExperienceService, WorkExperienceService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICityService, CityService>();

        }
    }
}
