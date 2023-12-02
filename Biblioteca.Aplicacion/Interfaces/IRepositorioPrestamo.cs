using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.Interfaces;

public interface IRepositorioPrestamo{
     void RealizarPrestamo(Prestamo prestamo);

     void DevolverLibro(Prestamo devolucion);
     List<Prestamo> ListarPrestamos();

     Prestamo ObtenerPrestamo (int id);
}