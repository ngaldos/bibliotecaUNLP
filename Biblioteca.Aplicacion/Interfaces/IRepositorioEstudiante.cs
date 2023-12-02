using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.Interfaces;

public interface IRepositorioEstudiante{
    void AgregarEstudiante ( Estudiante estudiante);
    void ModificarEstudiante ( Estudiante estudiante);
    void EliminarEstudiante (int idEstudiante);
    List<Estudiante> ListarEstudiantes();

    Estudiante ObtenerEstudiante (int id);
}