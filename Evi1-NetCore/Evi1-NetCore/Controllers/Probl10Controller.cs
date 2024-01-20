using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    public class Probl10Controller : ControllerBase 

    {
        [HttpGet]
        [Route("Area/{Radio1:int}/{Radio2:int}")]

        public IActionResult Area(int Radio1, int Radio2)
        {
            String Resultado = "El area del circulo es : " + (Radio1 * Radio2);

            return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }

    }
}
