using ProyectoCrud.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProeyectoCrud.Models;
using ProeyectoCrud.DAL.DataContext;

namespace ProyectoCrud.DAL.DataContext
{
    internal class ContactoRepository : IGenericRepositorie<Usuario>
    {

        private readonly examenContext _examenContext;

        public ContactoRepository(examenContext context) 
        {
            _examenContext = context;
        }

        public ContactoRepository()
        {
                    
        }


        public async Task<bool> Actualizar(Usuario modelo)
        {
            _examenContext.Usuarios.Update(modelo);
            await _examenContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Usuario modelo = _examenContext.Usuarios.First(c => c.Id == id);
            _examenContext.Usuarios.Remove(modelo);
            await _examenContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Usuario modelo)
        {
            _examenContext.Usuarios.Add(modelo);
            await _examenContext.SaveChangesAsync();
            return true;
        }

        public async Task<Usuario> Obtener(int id)
        {
            return await _examenContext.Usuarios.FindAsync(id);
        }

        public Task<IQueryable<Usuario>> ObtenerTodos()
        {
            IQueryable<Usuario> queryUsuarioSQL = _examenContext.Usuarios;
            return queryUsuarioSQL;
        }
    }
}
