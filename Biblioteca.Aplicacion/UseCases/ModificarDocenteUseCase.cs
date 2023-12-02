using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class ModificarDocenteUseCase : DocenteUseCase {

    public ModificarDocenteUseCase(IRepositorioDocente repositorioD) : base(repositorioD)
{
}

    public void Ejecutar(Docente docente){
        if (docente == null){
            throw new ArgumentNullException(nameof(docente), "El docente es invalido.");
        }
        RepositorioDocente.ModificarDocente(docente);
    }
}