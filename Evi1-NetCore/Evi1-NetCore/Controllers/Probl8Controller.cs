using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl8Controller : ControllerBase
    {

        [HttpGet]
        [Route("Area/{Num1:int}/{Num2:int}")]

        public IActionResult Area(int Num1, int Num2)
        {
            String Resultado = "El area del cuadrado es : " + (Num1 * Num2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }
    }
}
