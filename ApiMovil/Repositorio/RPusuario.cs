using ApiMovil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMovil.Repositorio
{
    public class RPusuario
    {
        public static List<Usuario> _listaUsuarios = new List<Usuario>()
        {
            new Usuario() { Id = 1, Nombre = "Cliente 1" , Apellido = "Apellido 1" },
            new Usuario() { Id = 2, Nombre = "Cliente 2" , Apellido = "Apellido 2" },
            new Usuario() { Id = 3, Nombre = "Cliente 3" , Apellido = "Apellido 3" }
        };

        public IEnumerable<Usuario> ObtenerClientes()
        {
            return _listaUsuarios;
        }

        public Usuario ObtenerUsuario(int id)
        {
            var cliente = _listaUsuarios.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void Agregar(Usuario nuevoUsuario)
        {
            _listaUsuarios.Add(nuevoUsuario);
        }
    }
}
