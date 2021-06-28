using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            try
            {
                return _context.Eventos.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
            
            // return new Evento [] {
            //     new Evento(){
            //         EventoId = 1, 
            //         Tema = "Angular e .NET Core", 
            //         Local = "Belo Horizonte",
            //         Lote = "1º Lote",
            //         QtdPessoas = 250,
            //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            //         },
            //         new Evento(){
            //         EventoId = 2, 
            //         Tema = "Angular e outras técnologias", 
            //         Local = "São Paulo",
            //         Lote = "2º Lote",
            //         QtdPessoas = 350,
            //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            //         }
            // };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento [] {
                new Evento(){
                    EventoId = 1, 
                    Tema = "Angular e .NET Core", 
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                    },
                    new Evento(){
                    EventoId = 2, 
                    Tema = "Angular e outras técnologias", 
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                    }
            }.FirstOrDefault(x => x.EventoId == id);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
