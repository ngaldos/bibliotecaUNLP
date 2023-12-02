using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;



public class ListarLibroUseCase : LibroUseCase{

    public ListarLibroUseCase (IRepositorioLibro repositorioL ) : base(repositorioL){
    
    }

    public List<Libro> Ejecutar(){
        return RepositorioLibro.ListarLibros();
    }
}