using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl4Controller : ControllerBase
    {
        [HttpGet]
        [Route("Resta/{Num1:int}/{Num2:int}")]

        public IActionResult Resta(int Num1, int Num2)
        {
            String Resultado = "La resta es : " + (Num1 - Num2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }

    }
}
