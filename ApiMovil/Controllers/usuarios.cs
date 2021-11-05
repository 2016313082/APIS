using ApiMovil.Models;
using ApiMovil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMovil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarios : ControllerBase
    {
        // GET: api/<usuarios>
        [HttpGet]
        public IActionResult Get()
        {
            RPusuario rpUsuario = new RPusuario();
            return Ok(rpUsuario.ObtenerClientes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPusuario rpUsuario = new RPusuario();

            var cliRet = rpUsuario.ObtenerUsuario(id);

            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarCliente(Usuario nuevoUsuario)
        {
            RPusuario rpCli = new RPusuario();
            rpCli.Agregar(nuevoUsuario);
            return CreatedAtAction(nameof(AgregarCliente), nuevoUsuario);
        }
    }
}
