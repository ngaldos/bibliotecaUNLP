using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;


public class ModificarLibroUseCase : LibroUseCase {
    public ModificarLibroUseCase (IRepositorioLibro repositorioL) : base(repositorioL){
        
    }

    public void Ejecutar(Libro libro) {
        if (libro == null){
            throw new ArgumentNullException(nameof(libro), "El libro es invalido.");
        }
        
        RepositorioLibro.ModificarLibro(libro);
    }
}