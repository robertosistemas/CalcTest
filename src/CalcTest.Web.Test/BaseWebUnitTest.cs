using CalcTest.Core.Tests;
using CalcTest.Web.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CalcTest.Web
{
    public class BaseWebUnitTest : BaseUnitTest
    {

        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseWebUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraHttpService, CalculadoraHttpService>();
            serviceProvider = services.BuildServiceProvider();
        }

    }
}
