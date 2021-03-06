using AutoMapper;
using BusinessLogicalLayer;
using Entities;
using Entities.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCPresentationLayer.Models.InsertModels;
using MVCPresentationLayer.Models.QueryModels;
using MVCPresentationLayer.Models.UpdateModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer
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
            services.AddAuthentication("CookieAuthentication")
      .AddCookie("CookieAuthentication", config =>
      {
          config.Cookie.Name = "UserLoginCookie";
          config.LoginPath = "/Home/Index";
          config.AccessDeniedPath = "/Home/Index";
      });


            services.AddControllersWithViews()
                .AddFluentValidation();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserQueryViewModel>();
                cfg.CreateMap<Food, FoodQueryViewModel>();
                cfg.CreateMap<Meal, MealQueryViewModel>();
                cfg.CreateMap<Restriction, RestrictionQueryViewModel>();

                cfg.CreateMap<RestrictionInsertViewModel, Restriction>();
                cfg.CreateMap<FoodCategoryInsertViewModel, FoodCategory>();
                cfg.CreateMap<UserInsertViewModel, User>();
                cfg.CreateMap<MealInsertViewModel, Meal>();
                cfg.CreateMap<FoodInsertViewModel, Food>();
                cfg.CreateMap<DietInsertViewModel, Diet>();

                cfg.CreateMap<UserUpdateViewModel, User>();
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            services.AddTransient<IFood_CategoryService, Food_CategoryBLL>();
            services.AddTransient<IMealService, MealBLL>();
            services.AddTransient<IUserService, UserBLL>();
            services.AddTransient<IFoodService, FoodBLL>();
            services.AddTransient<IDietService, DietBLL>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            
            app.UseStaticFiles();
            
            app.UseRouting();
            
            app.UseAuthentication();
            
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
