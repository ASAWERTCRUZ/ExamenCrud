using ProeyectoCrud.Models;
using ProeyectoCrud.DAL.

namespace ProyectoCrud.NG.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepositorie<Usuario> _usuarioRepo;

        public UsuarioService(IGenericRepositorie<Usuario> usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
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
