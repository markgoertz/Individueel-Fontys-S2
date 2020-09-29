using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussines_Logic_Layer__BLL_.Logic_BLL;
using Data_access_layer.Handlers;
using Interfaces.BLL.interfaces;
using Interfaces.Handlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP.NET_CORE_MVC_Car_To_Go
{
    public class Startup
    {
        private readonly string ConnectionString = "";
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            ConnectionString = configuration["ConnectionStrings:DefaultConnection"];
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            
            services.AddScoped<ICarDatabaseHandler, CarDatabaseHandler>();
            services.AddScoped<ICarBLL, CarBLL>();
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
                endpoints.MapRazorPages();
            });

            //Connectionstring binder

            CarDatabaseHandler.SetConnectionString(ConnectionString);
        }
    }
}
