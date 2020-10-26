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
            services.AddScoped<IProfileAdjustmentService, ProfileAdjustmentService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IEmployeeCompetencyService, EmployeeCompetencyService>();
            services.AddScoped<IFamilySituationService, FamilySituationService>();
            services.AddScoped<IEmployeeExamService, EmployeeExamService>();
            services.AddScoped<IEmployeeEducationService, EmployeeEducationService>();
            services.AddScoped<INationalityService, NationalityService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ILanguageSkillService, LanguageSkillService>();
            services.AddScoped<ICompetencyService, CompetencyService>();
            services.AddScoped<IKnowledgeLevelService, KnowledgeLevelService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IEmployeeTitleService, EmployeeTitleService>();
            services.AddScoped<ISeniorityLevelService, SeniorityLevelService>();
            services.AddScoped<ICountryService, CountryService>();

        }
    }
}
