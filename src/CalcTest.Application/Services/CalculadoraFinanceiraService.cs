using CalcTest.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Application.Services
{
    public class CalculadoraFinanceiraService : ICalculadoraFinanceiraService
    {

        private readonly ICalculadoraService _calculadoraService;

        public CalculadoraFinanceiraService(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        public CalculoOutputDto CalculaJurosComposto(CalculoInputDto calculoInputDto)
        {
            var calculo = new Calculo(calculoInputDto.ValorInicial, calculoInputDto.Meses);
            var resultado = _calculadoraService.CalculaJurosComposto(calculo);
            return new CalculoOutputDto(resultado.Resultado);
        }
    }
}
