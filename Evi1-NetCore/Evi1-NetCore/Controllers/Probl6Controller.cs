using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl6Controller : ControllerBase 
    {
        [HttpGet]
        [Route("Promedio/{Num1:int}/{Num2:int}/{Num3:int}")]

        public IActionResult Promedio(int Num1, int Num2, int Num3)
        {
            String Resultado = "El promedio de las 3 calificaciones es : " + (Num1 + Num2 + Num3 / 3);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }

    }
}
