using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Application.Services
{
    public interface ICalculadoraFinanceiraService
    {
        CalculoOutputDto CalculaJurosComposto(CalculoInputDto calculo);
    }
}
