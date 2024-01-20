using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl12Controller : ControllerBase
    {
        [HttpGet]
        [Route("Area/{Base1:int}/{Altura2:int}")]

        public IActionResult Area(int Base1, int Altura2)
        {
            String Resultado = "El area del rectangulo es : " + (Base1 * Altura2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }


    }
}
