using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.Interfaces;


public interface IRepositorioLibro{
    void AgregarLibro ( Libro libro);
    void ModificarLibro ( Libro libro);
    void EliminarLibro (int idLibro);

    Libro ObtenerLibro (int idLibro);
    List<Libro> ListarLibros();
}