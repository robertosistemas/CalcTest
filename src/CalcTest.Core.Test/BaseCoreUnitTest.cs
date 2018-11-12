using CalcTest.Core.Domains;
using CalcTest.Core.Tests;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CalcTest.Core
{
    public class BaseCoreUnitTest: BaseUnitTest
    {

        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseCoreUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraService, CalculadoraService>();
            serviceProvider = services.BuildServiceProvider();
        }

    }
}
