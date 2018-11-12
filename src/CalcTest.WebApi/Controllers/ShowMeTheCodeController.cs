using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{

    /// <summary>
    /// Este responde pelo path relativo /showmethecode Deverá retornar a url de onde encontra-se o fonte no github
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "https://github.com/robertosistemas/RepositorioTeste01";
        }

    }


}