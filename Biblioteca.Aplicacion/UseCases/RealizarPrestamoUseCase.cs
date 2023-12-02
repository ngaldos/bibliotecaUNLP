using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class RealizarPrestamoUseCase : PrestamoUseCase{
    public RealizarPrestamoUseCase (IRepositorioPrestamo repositorioP): base(repositorioP){
    }

    public void Ejecutar( Prestamo prestamo){
        if (prestamo == null){
            throw new ArgumentNullException(nameof(prestamo), "El prestamo es invalido.");
        }
            RepositorioPrestamo.RealizarPrestamo(prestamo);
    }
}