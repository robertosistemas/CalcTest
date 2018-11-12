using System;

namespace CalcTest.Core.Domains
{
    public class Calculo
    {
        public double ValorInicial { get; set; }
        public int Meses { get; set; }
        public double Resultado { get; set; }

        public Calculo(double valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }

        public void Calcula(double juros)
        {
            Resultado = ValorInicial * Math.Pow(1 + juros, Meses);
            // truca valor com duas casas decimais sem arredondar
            Resultado = Math.Truncate(100 * Resultado);
            Resultado = Resultado / 100;
        }

        public override string ToString()
        {
            //return base.ToString();
            return Resultado.ToString("###########0.00");
        }

    }
}
