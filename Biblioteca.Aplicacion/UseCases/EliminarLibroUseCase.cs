using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;


public class EliminarLibroUseCase : LibroUseCase{

 
   public EliminarLibroUseCase(IRepositorioLibro repositorioL) : base(repositorioL)
    {
    }

    public void Ejecutar(int idLibro){
        // la validacion se realiza en el repositorio
        RepositorioLibro.EliminarLibro(idLibro);
    }
}