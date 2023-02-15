using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;
using System.Configuration;
using System.Security.Policy;
using RollOff.Models;
using Microsoft.EntityFrameworkCore;

namespace RollOff
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
            var connection = "Data Source = LIN24006509\\SQLEXPRESS; Initial Catalog = Project; Integrated Security = True";
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(connection));
            //services.AddHttpClient<IService, RollServices>(c => c.BaseAddress = new Uri("http://localhost:25962"));
            // var client = new HttpClient();
            
            //var client = new HttpClient();
            //var url = "http://localhost:25962";
            //Uri uri = new Uri(url);
            //Uri myUri = new Uri("http://localhost:25962", UriKind.Absolute);
            //client.BaseAddress = new Uri(myUri);
            //services.AddHttpClient<IService, RollServices>(client => client.BaseAddress = new Uri("http://localhost:25962"));

            //client.BaseAddress = new Uri("http://localhost:52044/api/");
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Create}/{id?}");
            });
        }
    }
}
