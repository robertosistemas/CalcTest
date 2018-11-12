using CalcTest.Web.Services;
using CalcTest.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace CalcTest.Web.Areas.Mpa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICalculadoraHttpService _calculadoraHttpService;

        [BindProperty]
        public CalculoViewModel Calculo { get; set; }

        public bool Pesquisado { get; private set; }

        public IndexModel(ICalculadoraHttpService calculadoraHttpService)
        {
            _calculadoraHttpService = calculadoraHttpService;
        }

        public async Task OnPostAsync()
        {
            Pesquisado = true;
            this.Calculo.Resultado = await _calculadoraHttpService.CalcularJurosAsync(Calculo.ValorInicial.Value, Calculo.Meses.Value);
        }

    }
}
