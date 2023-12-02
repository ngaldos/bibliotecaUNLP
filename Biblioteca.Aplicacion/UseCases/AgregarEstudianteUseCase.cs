using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.Entidades;

namespace Biblioteca.Aplicacion.UseCases;


public class AgregarEstudianteUseCase : EstudianteUseCase {

    public AgregarEstudianteUseCase(IRepositorioEstudiante repositorioE) : base(repositorioE)
      {
      }

public void Ejecutar(Estudiante estudiante){
    if (estudiante == null){
        throw new ArgumentNullException(nameof(estudiante), "El estudiante es invalido.");
    }
    RepositorioEstudiante.AgregarEstudiante(estudiante);
}
}