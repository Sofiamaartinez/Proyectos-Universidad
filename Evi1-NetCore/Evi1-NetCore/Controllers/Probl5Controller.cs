using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl5Controller : ControllerBase 
    {
        [HttpGet]
        [Route("Multiplicacion/{Num1:int}/{Num2:int}")]

        public IActionResult Mutiplicacion(int Num1, int Num2)
        {
            String Resultado = "El resultado de la multiplicacion es : " + (Num1 * Num2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }

    }
}
