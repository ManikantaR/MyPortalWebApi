using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyPortal.Core.Repositories;
using MyPortal.Core.Services;
using MyPortal.Infrastructure.Data;
using MyPortal.Infrastructure.Data.Repositories;
using MyPortal.WebApi.Filters;
using MyPortal.WebApi.Models.Validators;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;


namespace MyPortal.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IHostingEnvironment env)
        {
            Configuration = configuration;
            contextrootPath = AppContext.BaseDirectory;
        }

        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }


        public IConfiguration Configuration { get; }

        private string contextrootPath;



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyPortalDbContext>(
             options => options.UseLoggerFactory(GetLoggerFactory()).
             UseSqlServer(Configuration.GetConnectionString("MyPortal")));

            services.AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<DashboardValidator>()); ;

            services.AddAutoMapper();

            //Repostories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();

            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IDashboardService, DashboardService>();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerDocument();


        }

        private string GetConnectionString()
        {
            string conn = Configuration.GetConnectionString("MyPortal");
            if (conn.Contains("%CONTENTROOTPATH%\\"))
            {
                conn = conn.Replace("%CONTENTROOTPATH%\\", contextrootPath);
            }
            return conn;
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
          

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwagger();
            app.UseSwaggerUi3();


        }
    }
}
