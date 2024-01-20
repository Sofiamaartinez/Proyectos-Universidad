using Microsoft.AspNetCore.Mvc;

namespace Evi1_NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Problema1Controller : ControllerBase
    {

        [HttpGet]
        [Route("Mensaje/(Nombre)")]

        public IActionResult Mensaje(String Nombre)
        {
            string Mensaje = "Hola " + Nombre + ", esta es mi primer WEB API :')";

            return StatusCode(StatusCodes.Status200OK, new { Mensaje });
        }

    }

    

    



}
