using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class ModificarEstudianteUseCase : EstudianteUseCase {

     public ModificarEstudianteUseCase(IRepositorioEstudiante repositorioE) : base(repositorioE)
{
}

    public void Ejecutar(Estudiante estudiante){
        if (estudiante == null){
            throw new ArgumentNullException(nameof(estudiante), "El estudiante es invalido.");
        }
        RepositorioEstudiante.ModificarEstudiante(estudiante);
    }   
}
