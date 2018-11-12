using System.Globalization;

namespace CalcTest.Core.Tests
{
    public class BaseUnitTest
    {
        public BaseUnitTest()
        {

            var culture = new CultureInfo("pt-BR");
            culture.NumberFormat.NumberDecimalSeparator = ",";
            culture.NumberFormat.NumberGroupSeparator = ".";
            culture.NumberFormat.CurrencyDecimalSeparator = ",";
            culture.NumberFormat.CurrencyGroupSeparator = ".";

            var UIculture = new CultureInfo("pt-BR");
            UIculture.NumberFormat.NumberDecimalSeparator = ",";
            UIculture.NumberFormat.NumberGroupSeparator = ".";
            UIculture.NumberFormat.CurrencyDecimalSeparator = ",";
            UIculture.NumberFormat.CurrencyGroupSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = UIculture;

        }

    }
}
