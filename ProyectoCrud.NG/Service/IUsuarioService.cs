using ProeyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.NG.Service
{
    public interface IUsuarioService
    {
        //Metodos que se usaran para el contrato

        //insertar modelo
        Task<bool> Insertar(Usuario modelo);
        //actualizar modelo
        Task<bool> Actualizar(Usuario modelo);
        //Elimar Modelos
        Task<bool> Eliminar(int id);

        Task<Usuario> Obtener(int id);
        //listar Modelo
        Task<IQueryable<Usuario>> ObtenerTodos();

        //Aca se hace la logica de negocios 
        //y tambien se da las operaciones por filtros y demas

        Task<Usuario> ObtenerPorNombre(string nombreUsuario);

    }
}
