using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class DevolverLibroUseCase : PrestamoUseCase {

    public DevolverLibroUseCase (IRepositorioPrestamo repositorioP) : base(repositorioP){
    
    }

    public void Ejecutar(Prestamo devolucion){
        if (devolucion == null){
            throw new ArgumentNullException(nameof(devolucion), "La devolucion recibida es invalida.");
        }
        RepositorioPrestamo.DevolverLibro(devolucion);
    }
}