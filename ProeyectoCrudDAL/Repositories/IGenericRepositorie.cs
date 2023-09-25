namespace ProyectoCrud.DAL.Repositories
{
    public interface IGenericRepositorie<TEntityModel> where TEntityModel : class
    {
        //Metodos que se usaran para el contrato

        //insertar modelo
        Task<bool> Insertar(TEntityModel modelo);
        //actualizar modelo
        Task<bool> Actualizar(TEntityModel modelo);
        //eliminar
        Task<bool> Eliminar(int id);

        Task<TEntityModel> Obtener(int id);
        //listar Modelo
        Task<IQueryable<TEntityModel>> ObtenerTodos();
    }
}
