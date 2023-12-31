using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PruebaDoubleV.Application.Services;
using PruebaDoubleV.Application.Services.Interfaces;
using PruebaDoubleV.Domain.Services;
using PruebaDoubleV.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PruebaDoubleV", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<DbContextDoubleV>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DbConeccionSQL")));

            services.AddScoped<IDoubleVAppService, DoubleVAppService>();
            services.AddScoped<IDoubleVDomainService, DoubleVDomainService>();
            services.AddCors(options => options.AddPolicy("AllowWebApp",
                            builder => builder.AllowAnyOrigin()
                                                .AllowAnyHeader()
                                                .AllowAnyMethod()));
            services.AddControllers(mvcOpts =>
            {
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PruebaDoubleV v1"));
            }
            app.UseCors("AllowWebApp");
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
