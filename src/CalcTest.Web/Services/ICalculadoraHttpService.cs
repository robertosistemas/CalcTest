using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcTest.Web.Services
{
    public interface ICalculadoraHttpService
    {
        Task<string> CalcularJurosAsync(double valorInicial, int meses);
    }
}
