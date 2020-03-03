using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Star_Wars.API.Extensions;
using Star_Wars.Application;
using Star_Wars.CrossCutting.IoC;
using Star_Wars.Infra.Data.Context;

namespace Star_Wars.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<Star_WarsContext>(o => o.UseMySql(Configuration.GetConnectionString("StarWars")));

            // services.AddDbContext<Star_WarsContext>(o => o.UseMySql(Configuration.GetConnectionString("Star_Wars")));

            //Politica de acesso
            // services.AddCors(options =>
            // {
            //options.AddPolicy("AllowOrigin",
            //builder => builder.WithOrigins("https://localhost:5003")
            //.WithMethods("GET"));
            // options.AddPolicy("AllowOrigin", builder =>
            // {
            // builder.AllowAnyOrigin()
            //  .AllowAnyMethod()
            //  .AllowAnyHeader()
            //  .AllowCredentials();
            //});



            //});


            services.AddMvc();
            InjetorDependency.Registrar(services);

            //services.AddAutoMapper(x => x.AddProfile(new MappingEntities()));
            // services.AddAutoMapperSetup();

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingEntities());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

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

            app.UseCors(a => a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        }
    }
}
