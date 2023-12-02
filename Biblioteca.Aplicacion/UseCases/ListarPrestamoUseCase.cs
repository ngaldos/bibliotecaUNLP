using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class ListarPrestamoUseCase : PrestamoUseCase  {
    public ListarPrestamoUseCase (IRepositorioPrestamo repositorioP) : base(repositorioP){
    
    }

    public List<Prestamo> Ejecutar(){
        return RepositorioPrestamo.ListarPrestamos();
    }
}