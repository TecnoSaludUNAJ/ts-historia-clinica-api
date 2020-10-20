using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TP_AccessData;
using SqlKata.Compilers;
using TP_Domain.Commands;
using TP_AccessData.Commands;
using TP_Domain.Queries;
using TP_Application.Services;
using TP_AccessData.Queries;

namespace TP_Template_API
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
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<TemplateDbContext>(options => options.UseSqlServer(connectionString));

            // Swagger
            services.AddSwaggerGen();

            // SqlKata
            services.AddTransient<Compiler, SqlServerCompiler>();
            services.AddTransient<IDbConnection>(b =>
            {
                return new SqlConnection(connectionString);
            });


            //Injection dependences
            services.AddTransient<IGenericsRepository, GenericsRepository>();
            services.AddTransient<IAnalisisService, AnalisisService>();
            services.AddTransient<IRegistroService, RegistroService>();
            services.AddTransient<IRecetaService, RecetaService>();
            services.AddTransient<IHistoriaClinicaService, HistoriaClinicaService>();
            services.AddTransient<IHistoriaClinicaQueries, HistoriaClinicaQueries>();
            services.AddTransient<IRegistroQueries, RegistroQueries>();

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template API V1");
            });
        }
    }
}
