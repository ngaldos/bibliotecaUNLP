using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.Entidades;


namespace Biblioteca.Aplicacion.UseCases;

public abstract class LibroUseCase
{
protected IRepositorioLibro RepositorioLibro { get; private set; }

public LibroUseCase(IRepositorioLibro repositorioL)
  {
    this.RepositorioLibro = repositorioL;
  }
}