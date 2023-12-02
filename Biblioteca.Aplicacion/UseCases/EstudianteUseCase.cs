using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public abstract class EstudianteUseCase
{
protected IRepositorioEstudiante RepositorioEstudiante { get; private set; }

public EstudianteUseCase(IRepositorioEstudiante repositorioE)
  {
    this.RepositorioEstudiante = repositorioE;
  }
}