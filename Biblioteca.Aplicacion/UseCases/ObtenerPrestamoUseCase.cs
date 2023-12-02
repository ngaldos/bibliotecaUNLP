using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;
namespace Biblioteca.Aplicacion.UseCases;
public class ObtenerPrestamoUseCase : PrestamoUseCase
{
 public ObtenerPrestamoUseCase(IRepositorioPrestamo repositorio) : base(repositorio)
 {
 }
 public Prestamo? Ejecutar(int id)
 {
    return RepositorioPrestamo.ObtenerPrestamo(id);
 }
}
