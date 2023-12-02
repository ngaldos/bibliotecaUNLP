using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.Entidades;


namespace Biblioteca.Aplicacion.UseCases;

public abstract class DocenteUseCase
{
protected IRepositorioDocente RepositorioDocente { get; private set; }

public DocenteUseCase(IRepositorioDocente repositorioD)
  {
    this.RepositorioDocente = repositorioD;
  }
}