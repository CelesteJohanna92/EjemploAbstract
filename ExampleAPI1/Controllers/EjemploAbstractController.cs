using Microsoft.AspNetCore.Mvc;
using ExampleAPI1.EjemploClaseAbstracta;

namespace ExampleAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploAbstractController : ControllerBase
    {
        [HttpGet]
        public string EjemploClaseAbstracta()
        {
            GatoA gatoA = new GatoA();
            return gatoA.ObtenerHorasSueño();

            //return gatoA.ObtenerHorasSueño();
        }
            
    }
}
