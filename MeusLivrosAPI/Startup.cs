using MeusLivrosAPI.Data;
using MeusLivrosAPI.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace MeusLivrosAPI
{
    public class Startup
    {
        //Francisco
        public string ConnectionString { get; set; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //Francisco
            ConnectionString = Configuration.GetConnectionString("DefaultConnectionString");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            //Francisco - Configure DBContext With SQL
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));

            //Francisco - Configure ServicesL
            services.AddTransient<LivrosService>();
            services.AddTransient<AutorsService>();
            services.AddTransient<PublicarService>();

            services.AddSwaggerGen(c =>
            {
                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "MeusLivrosAPI", Version = "v1" });
                //c.SwaggerDoc("v2", new OpenApiInfo { Title = "MeusLivrosAPI-Titulos", Version = "v2" });
                c.SwaggerDoc("v2", new OpenApiInfo { Title = " API MeusLivros, Get, GetList, Post, Put-Update Delete", Version = "v2" });

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v2/swagger.json", "MeusLivrosAPI-UI-Update v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //AppDbInitializer.Seed(app);
        }
    }
}
