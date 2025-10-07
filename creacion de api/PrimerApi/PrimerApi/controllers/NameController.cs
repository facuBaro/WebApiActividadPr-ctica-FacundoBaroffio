using Microsoft.AspNetCore.Mvc;

namespace PrimerApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController :ControllerBase
    {
        [HttpGet("Leer/{name}")]
        public string Get(string name) {

            return name switch
            {
                "Pepe" => "Id de Pepe: 1, Bienvenido",
                "Juan" => "Id de Juan: 2, Bienvenido",
                "Ana" => "Id de Ana: 3, Bienvenida",
                _=>"No encontrado",
            };
        
        }
    }
}
