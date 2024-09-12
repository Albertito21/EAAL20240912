using Microsoft.AspNetCore.Mvc;
using EAAL20240912.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EAAL20240912.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        // Declaracion de una lista estática de onjetos 
        // "Docente" para almacenar docentes
        static List<Docente> docentes = new List<Docente>();

        // Definicion de un metodo HTTP GET
        // que devuelve una coleccion de docente
        [HttpGet]
        public IEnumerable<Docente> Get()
        {
            return docentes;
        }

        //Definicion de un metodo HTTP GET
        // que recibe un ID como parametro y devuelve un docente especifico
        [HttpGet("{id}")]
        public Docente Get(int id)
        {
            var docente = docentes.FirstOrDefault(c => c.Id == id);
            return docente;
        }

        // Definicion de un metodo HTTP POST
        // para agregar un nuevo docente a la lista
        [HttpPost]
        public IActionResult Post([FromBody] Docente docente)
        {
            docentes.Add(docente);
            return Ok();
        }
    }
}