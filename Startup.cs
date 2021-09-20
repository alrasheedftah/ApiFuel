using System.Text;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Helpers;
using ApiAppPetrol.Models;
using ApiAppPetrol.Policies;
using ApiAppPetrol.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
// using OilCar.ALRASHID;
// using WebApplication1.Models;

namespace ApiAppPetrol
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
                // TODO  Update Server DataBases Connection 
   
  services.AddDbContext<PetrolSDContext>(
        options => options.UseNpgsql(Configuration.GetConnectionString("PetrolsdContextConnection"))
    );

    services.AddDbContext<PetrolUserSDContext>(
        options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
    );
   

        ///   Serrvices Application Debendancy Injection 
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<PetrolUserSDContext>().
            AddDefaultTokenProviders();

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


            services.AddScoped<IVehicleAssentService, VehicleAssentService>();
            // services.AddScoped<IMachineAssentServices, MachineAssentServices>();
            services.AddScoped<IStationService, StationService>();//
            services.AddScoped<IFuelTypeServices, FuelTypeServices>();
            services.AddScoped<ICompanyService, CompanyService>();//
            services.AddScoped<IProfileFacilityAssentService, ProfileFacilityAssentService>();//
            services.AddScoped<ISiteSurvey, SiteSurvey>();//
            services.AddScoped<ILocalityServices,LocalityServices>();
            services.AddScoped<IVehicleService,VehicleService>();
            services.AddScoped<IVehicleService,VehicleService>();
            services.AddScoped<IStateService,StateService>();
            services.AddScoped<ITripAuthService,TripAuthService>();
            services.AddScoped<ITripAuthProviderService,TripAuthProviderService>();
            services.AddScoped<IRoadTypeService,RoadTypeService>();







            // configure DI for application services
            services.AddScoped<IUserService, UserService>();
        ///   Serrvices Application Debendancy Injection 
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddControllers(options =>
                options.Filters.Add(new HttpResponseExceptionFilter())
            );

            services.AddAuthorization(config =>{
                config.AddPolicy(PoliciesCustom.Station, PoliciesCustom.StationPolicy());
                config.AddPolicy(PoliciesCustom.Engineer, PoliciesCustom.EnginnerPolicy());
                config.AddPolicy(PoliciesCustom.SecurityAgent, PoliciesCustom.SecurityAgentPolicy());
                config.AddPolicy(PoliciesCustom.BusAssent, PoliciesCustom.BusAssentPolicy());
                config.AddPolicy(PoliciesCustom.TruckAssent, PoliciesCustom.TruckAssentPolicy());
                }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // app.UseExceptionHandler("/error");
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization( 
            );
 // services.AddDbContext<PetrolTestsdContext>(
// using Microsoft.AspNetCore.HttpsPolicy;
    //     options => options.UseMySQL(Configuration.GetConnectionString("PetrolsdContextConnection"))
    // );

    // services.AddDbContext<PetrolUserSDContext>(
    //     options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"))
    // );
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
