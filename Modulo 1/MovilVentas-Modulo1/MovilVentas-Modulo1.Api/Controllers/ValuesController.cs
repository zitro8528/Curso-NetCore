using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovilVentas_Modulo1.Api.Services;
using MovilVentasModulo1.Domain.Interfaces;

namespace MovilVentas_Modulo1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        INotificacionPedidos NotificacionPedidos;

        public ValuesController(INotificacionPedidos notificacionPedidos)
        {
            NotificacionPedidos = notificacionPedidos;
        }
        /// <summary>
        /// Get this instance.
        /// </summary>
        /// <returns>The get.</returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        { 
            string msg = NotificacionPedidos.MostrarNotificacion("Hola", "saludo a el curso de .net core");

            return new string[] { "value1", "value2", msg };
        }
        /// <summary>
        /// Get the specified id.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="id">Identifier.</param>
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
