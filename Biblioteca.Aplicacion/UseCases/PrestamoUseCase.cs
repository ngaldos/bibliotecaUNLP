using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.Entidades;


namespace Biblioteca.Aplicacion.UseCases;

public abstract class PrestamoUseCase
{
protected IRepositorioPrestamo RepositorioPrestamo { get; private set; }

public PrestamoUseCase(IRepositorioPrestamo repositorioP)
  {
    this.RepositorioPrestamo = repositorioP;
  }
}