using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mobile.DataAccess;
using mobile.DataAccess.Interfaces;
using mobile.DataAccess.Repositories;
using mobile.Domain.Models;
using mobile.Services;
using mobile.Services.Helpers;
using mobile.Services.Interfaces;
using System;

namespace mobile.mk
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAutoMapper(opts =>
            {
                opts.AddProfile<MapperProfile>();
            });



            services.AddTransient<IUserRepository<User>, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRepository<Vehicle>, VehicleRepository>();
            services.AddTransient<IVehicleService, VehicleService>();
            services.AddTransient<IRepository<VehicleImage>, VehicleImageRepository>();
            services.AddTransient<IVehiclesImageService, VehicleImageService>();


            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/Users/Login";
                options.AccessDeniedPath = "/Users/Login";
                options.SlidingExpiration = true;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Connection String
            services.AddDbContext<mobileDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("mobileConnectionString")));



            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequireNonAlphanumeric = true;
            })


            .AddRoleManager<RoleManager<IdentityRole>>()
            .AddEntityFrameworkStores<mobileDbContext>()
            .AddDefaultTokenProviders();


           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Vehicles}/{action=Index}/{id?}");
            });
        }
    }
}
