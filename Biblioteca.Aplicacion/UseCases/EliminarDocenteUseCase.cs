using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class EliminarDocenteUseCase : DocenteUseCase {

   public EliminarDocenteUseCase(IRepositorioDocente repositorioD) : base(repositorioD)
    {
    }

    public void Ejecutar(int idDocente){
        // la validacion se realiza en el repositorio 
        RepositorioDocente.EliminarDocente(idDocente);
    }
}