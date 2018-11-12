using CalcTest.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalcTest.Web.Areas.Spa.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public CalculoViewModel Calculo { get; set; }

    }
}
