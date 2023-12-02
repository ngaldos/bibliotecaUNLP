using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;
namespace Biblioteca.Aplicacion.UseCases;
public class ObtenerEstudianteUseCase : EstudianteUseCase
{
 public ObtenerEstudianteUseCase(IRepositorioEstudiante repositorio) : base(repositorio)
 {
 }
 public Estudiante? Ejecutar(int id)
 {
    return RepositorioEstudiante.ObtenerEstudiante(id);
 }
}