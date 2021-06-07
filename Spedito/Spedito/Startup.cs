using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpeditoReposity.Data;
using Microsoft.EntityFrameworkCore;
using SpeditoReposity.Reposities.AuthReposities;
using AutoMapper;
using SpeditoReposity.Repositories.ContextRepositories;
using SpeditoReposity.Repositories.ShoppingReposities;
using Microsoft.AspNetCore.Http;

namespace Spedito
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

            services.AddMvc(
                config =>
                {
                    config.Filters.Add(new GlobalToken());
                });

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<SpeditoDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IContentRepository, ContentRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IBasketRepository, BasketRepository>();
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
