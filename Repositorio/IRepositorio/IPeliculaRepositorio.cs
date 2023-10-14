using ApiPeliculas.Modelos;

namespace ApiPeliculas.Repositorio.IRepositorio
{
    public interface IPeliculaRepositorio
    {
        ICollection<Pelicula> GetPeliculas();
        Pelicula GetPelicula(int peliculaId);
        bool ExistePelicula(string nombre);
        bool ExistePelicula(int id);
        bool CrearPelicula(Pelicula pelicula);
        bool ActualizaPelicula(Pelicula pelicula);
        bool EliminarPelicula(Pelicula pelicula);

        //Métodos para buscar peliculas por categoria y buscar peliculas por nombre
        ICollection<Pelicula> GetPeliculasPorCategoria(int categoriaId);
        ICollection<Pelicula> BuscarPelicula(string nombre);
        bool Guardar();
    }
}
