using ProeyectoCrud.Models;
using ProyectoCrud.DAL.Repositories;
using System.Linq;
using System.Threading.Tasks;
using ProeyectoCrud.Models;

namespace ProyectoCrud.NG.Service
{
    internal class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepositorie<Usuario> _usuarioRepo;

        public UsuarioService(IGenericRepositorie<Usuario> usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public async Task<bool> Actualizar(Usuario modelo)
        {
            return await _usuarioRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _usuarioRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Usuario modelo)
        {
            return await _usuarioRepo.Insertar(modelo);
        }

        public async Task<Usuario> Obtener(int id)
        {
            return await _usuarioRepo.Obtener(id);
        }

        public async Task<Usuario> ObtenerPorNombre(string nombreUsuario)
        {
            IQueryable<Usuario> queryUsuarioSQL = await _usuarioRepo.ObtenerTodos();
            Usuario usuario = queryUsuarioSQL.Where(c => c.Nombre == nombreUsuario).FirstOrDefault();
            return usuario;
        }

        public async Task<IQueryable<Usuario>> ObtenerTodos()
        {
            return await _usuarioRepo.ObtenerTodos();
        }
    }
}
