using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;
namespace Biblioteca.Aplicacion.UseCases;
public class ObtenerDocenteUseCase : DocenteUseCase
{
 public ObtenerDocenteUseCase(IRepositorioDocente repositorio) : base(repositorio)
 {
 }
 public Docente? Ejecutar(int id)
 {
    return RepositorioDocente.ObtenerDocente(id);
 }
}
