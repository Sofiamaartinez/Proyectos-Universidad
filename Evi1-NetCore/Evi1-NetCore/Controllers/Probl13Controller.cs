using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl13Controller : ControllerBase
    {

        [HttpGet]
        [Route("Area/{Base1:int}/{Altura2:int}/{Num3:int}")]

        public IActionResult Area(int Base1, int Altura2, int Num3)
        {
            String Resultado = "El area del triangulo es : " + (Base1 + Altura2 + Num3 / 2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }

    }
}
