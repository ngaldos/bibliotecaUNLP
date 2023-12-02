using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.UseCases;


public class AgregarDocenteUseCase : DocenteUseCase
{
public AgregarDocenteUseCase(IRepositorioDocente repositorioD) : base(repositorioD)
{
}

public void Ejecutar(Docente docente){
    if (docente == null){
        throw new ArgumentNullException(nameof(docente), "El docente es invalido.");
    }
    RepositorioDocente.AgregarDocente(docente);
}
}
