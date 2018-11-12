using CalcTest.Application.Services;
using CalcTest.Core.Domains;
using CalcTest.Core.Tests;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CalcTest.WebApi
{
    public class BaseWebApiUnitTest : BaseUnitTest
    {
        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseWebApiUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraService, CalculadoraService>();
            services.AddTransient<ICalculadoraFinanceiraService, CalculadoraFinanceiraService>();
            serviceProvider = services.BuildServiceProvider();
        }
    }
}