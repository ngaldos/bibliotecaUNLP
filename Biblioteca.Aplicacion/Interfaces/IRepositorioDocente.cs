using Biblioteca.Aplicacion.Entidades;

namespace Biblioteca.Aplicacion.Interfaces;

public interface IRepositorioDocente{
    void AgregarDocente ( Docente docente);
    void ModificarDocente ( Docente docente);
    void EliminarDocente (int id);

    Docente ObtenerDocente (int id);
    List<Docente> ListarDocentes();
}