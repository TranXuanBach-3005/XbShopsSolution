using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Application.Repositories.Repository;
using XbShopSolution.Application.Services.IService;
using XbShopSolution.Application.Services.Service;
using XbShopSolution.Application.UnitOfWorks;
using XbShopSolution.Data.EF;
using XbShopSolution.Data.Entities;
using XbShopSolution.Utilities.Constants;
using XbShopSolution.ViewModel.AutoMapper;

namespace XbShopSolution.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "XbShopSolution.API", Version = "v1" });
            });
            services.AddDbContext<xbSolutionDbContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString(SystemConstant.XbConnectionString));
            });
            services.AddIdentity<User, Role>()
                   .AddEntityFrameworkStores<xbSolutionDbContext>()
                   .AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddAutoMapper
        (typeof(Mapping).Assembly);

            //service,repository,unitofwork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISlideRepository, SlideRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<IProductInCategoryRepository, ProductInCategoryRepository>();
            services.AddScoped<UserManager<User>, UserManager<User>>();
            services.AddScoped<SignInManager<User>, SignInManager<User>>();
            services.AddScoped<RoleManager<Role>, RoleManager<Role>>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ISlideService, SlideService>();
            services.AddScoped<IFileService, FileService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "XbShopSolution.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
