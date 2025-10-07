using Microsoft.AspNetCore.Mvc;

namespace PrimerApi.controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("Leer/{id}")]
        public string Get(string id) {

            return id switch
            {
                "1"=>"Pepe",
                "2"=>"Juan",
                "3"=>"Ana",
                 _=>"no existe nadie que tenga relacion con ese id",
            };
        
        }
    }
}
