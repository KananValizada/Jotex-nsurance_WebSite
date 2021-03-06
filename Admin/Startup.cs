using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Libs;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Repository.Repositories.AdminRepositories;
using Repository.Repositories.ContentRepositories;
using Repository.Services;

namespace Admin
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
            services.AddControllersWithViews();
            services.AddDbContext<JotexDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Default"),
            x => x.MigrationsAssembly("Repository")
            ));
            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IFagRepository, FagRepository>();
            services.AddTransient<IBestServicesRepository, BestServicesRepository>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<IFileManager, FileManager>();
            services.AddTransient<IAboutUsRepository, AboutUsRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<IBlogPhotosRepository, BlogPhotosRepository>();
            services.AddTransient<IBlogCommentsRepository, BlogCommentsRepository>();
            services.AddTransient<IBlogSloganRepository, BlogSloganRepository>();
            services.AddTransient<IAboutUsRepository, AboutUsRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IAgentRepository, AgentRepository>();
            services.AddTransient<ICaseStudyRepository, CaseStudyRepository>();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=dashboard}/{action=Index}/{id?}");
            });
        }
    }
}
