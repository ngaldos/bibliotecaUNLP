using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;


public class EliminarEstudianteUseCase : EstudianteUseCase {

   public EliminarEstudianteUseCase(IRepositorioEstudiante repositorioE) : base(repositorioE)
    {
    }

    public void Ejecutar(int idEstudiante){
        // la validacion se realiza en el repositorio
        RepositorioEstudiante.EliminarEstudiante(idEstudiante);
    }
}