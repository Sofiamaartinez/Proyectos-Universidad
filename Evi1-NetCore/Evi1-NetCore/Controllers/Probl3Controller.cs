using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl3Controller : ControllerBase
    {
        [HttpGet]
        [Route("Suma/{Num1:int}/{Num2:int}")]

        public IActionResult Suma(int Num1, int Num2)
        {
            String Resultado = "La suma es : " + (Num1 + Num2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }


    }
}
