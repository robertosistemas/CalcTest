using CalcTest.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{

    /// <summary>
    /// A primeira reponde pelo path relativo "/calculajuros"
    /// Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final = Valor Inicial* (1 + juros) ^ Tempo
    /// Valor inicial é um decimal recebido como parâmetro Juros é 1% ou 0,01 (fixo no código)
    /// Tempo é um inteiro, que representa meses, também recebido como parâmetro ^ representa a operação de potência
    /// Resultado final deve ser truncado(sem arredondamento) em duas casas decimais
    /// Exemplo: /calculajuros? valorinicial = 100 & meses = 5 Resultado esperado: 105,10
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {

        private readonly ICalculadoraFinanceiraService _calculadoraFinanceiraService;

        public CalculaJurosController(ICalculadoraFinanceiraService calculadoraFinanceiraService)
        {
            _calculadoraFinanceiraService = calculadoraFinanceiraService;
        }

        // GET /CalculaJuros?valorinicial=100&meses=5
        [HttpGet]
        public ActionResult<string> Get(double valorInicial, int meses)
        {
            var calculoInputDto = new CalculoInputDto(valorInicial, meses);
            var calculo = _calculadoraFinanceiraService.CalculaJurosComposto(calculoInputDto);
            return calculo.ToString();
        }

    }
}