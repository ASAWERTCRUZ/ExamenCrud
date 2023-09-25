using ProeyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.NG.Service
{
    internal class UsuarioSevice : IUsuarioService

    {

        public UsuarioSevice(IGenericRepositorie<Usuario>)
        {
                
        }


        public Task<bool> Actualizar(Usuario modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Usuario modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ObtenerPorNombre(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Usuario>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
