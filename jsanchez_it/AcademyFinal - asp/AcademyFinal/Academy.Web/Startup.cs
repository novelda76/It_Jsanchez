using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Academy.Lib.DAL;
using Microsoft.EntityFrameworkCore;
using Common.Lib.Infrastructure;
using Common.Lib.Core;
using Academy.Web.App;
using Academy.Lib.Repositories;
using Academy.Lib.DAL.Repositories;


namespace Academy.Web
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
            //services.AddControllersWithViews();

            services.AddScoped<IStudentRepository, StudentRepository>();

            var dbConnection = Configuration.GetConnectionString("AcademyDbConnection");
            
            services.AddDbContext < AcademyDbContext >
                (options => options.UseSqlite(dbConnection, b => b.MigrationsAssembly("AcademyFinal.App.WPF")));


            var bootstrapper = new Bootstrapper();
            Entity.DepCon = new SimpleDependencyContainer();

            bootstrapper.Init(Entity.DepCon);

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

            app.UseRouting();

            app.UseDefaultFiles();  //esto levanta el html
            app.UseStaticFiles(); //esto levanta el html

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
