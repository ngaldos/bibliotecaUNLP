using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class ListarDocenteUseCase : DocenteUseCase{

    public ListarDocenteUseCase(IRepositorioDocente repositorioD) : base(repositorioD)
{
}

    public List<Docente> Ejecutar(){
         return RepositorioDocente.ListarDocentes();
    }
}