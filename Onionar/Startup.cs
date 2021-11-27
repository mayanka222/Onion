using BAL.Interface;
using BAL.Service;
using Microsoft.Extensions.Logging;
using DAL.Interface;
using DAL.Repository;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ModelClassConverter;

namespace Onionar
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
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false).Build();
            services.AddControllersWithViews();
            services.AddScoped<IStudent,Student>();
            services.AddScoped<IStudentsRepository, StudentsRepository>();
            services.AddScoped<ILogin, Login>();
            services.AddScoped<ILoginRepository,LoginRepository>();
            services.AddScoped<DataModelConvertToViewModel>();
            services.AddScoped<ViewModelConvertToDataModel>();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataContext")));
            services.AddLogging();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
                        var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\logs\\log.txt");
            //loggerFactory.AddFile


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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
