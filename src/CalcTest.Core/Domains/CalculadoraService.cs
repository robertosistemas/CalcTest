
namespace CalcTest.Core.Domains
{
    public class CalculadoraService : ICalculadoraService
    {

        private readonly double _juros;

        public CalculadoraService()
        {
            _juros = 0.01;
        }

        public Calculo CalculaJurosComposto(Calculo calculo)
        {

            calculo.Calcula(_juros);

            return calculo;
        }

    }
}
