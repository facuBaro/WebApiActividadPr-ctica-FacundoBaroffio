using Microsoft.AspNetCore.Mvc;

namespace PrimerApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActualizarController : ControllerBase
    {

        [HttpPut("Actualizar/{id}/{NuevoNombre}")]
        public string Put(string id,string NuevoNombre)
        {
            Console.WriteLine("Actualizando ID con nuevo nombre: " + NuevoNombre);
            return id switch
            {
                "1" => "Actualizando ID con nuevo nombre: " + NuevoNombre,
                "2" => "Actualizando ID con nuevo nombre: "+NuevoNombre,
                "3" => "Actualizando ID con nuevo nombre: "+NuevoNombre,
                _ => "no existe nadie que tenga relacion con ese id",
            };

        }

    } 
}