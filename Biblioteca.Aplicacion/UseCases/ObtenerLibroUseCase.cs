using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;
namespace Biblioteca.Aplicacion.UseCases;
public class ObtenerLibroUseCase : LibroUseCase
{
 public ObtenerLibroUseCase(IRepositorioLibro repositorio) : base(repositorio)
 {
 }
 public Libro? Ejecutar(int id)
 {
    return RepositorioLibro.ObtenerLibro(id);
 }
}
