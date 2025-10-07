using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace PrimerApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllDataController : ControllerBase
    {
        [HttpGet("obtenerTodo")]

        public List<string> lista()
        {
            return new List<string>{ "Nombre: Pepe-Id:1 /", "Nombre: Juan-Id:2 /", "Nombre: Ana-Id:3" };
        }
        //public string Get()
        //{
            
            //var lista = new List<string> { "Nombre: Pepe-Id:1 /", "Nombre: Juan-Id:2 /","Nombre: Ana-Id:3" };
            //string datos="";
            //foreach (var item in lista) {
            //    datos = datos + item;
              
        //    //}
        //    return datos;
        //}
    }
}
