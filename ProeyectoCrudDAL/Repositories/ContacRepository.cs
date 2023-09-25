using ProeyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repositories
{
    public class ContacRepository : IGenericRepositorie<Contacto>
    {
        public Task<bool> Actualizar(Contacto modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Contacto modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Contacto> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Contacto>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
