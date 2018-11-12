using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcTest.Application.Services;
using CalcTest.Core.Domains;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CalcTest.WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors();

            services.AddTransient<ICalculadoraService, CalculadoraService>();
            services.AddTransient<ICalculadoraFinanceiraService, CalculadoraFinanceiraService>();

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
                app.UseHsts();
            }

            // https://stackoverflow.com/questions/44379560/how-to-enable-cors-in-asp-net-core-webapi

            app.UseCors("*");

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
