using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Aplicacion.UseCases;

public class ListarEstudianteUseCase : EstudianteUseCase{

       public ListarEstudianteUseCase(IRepositorioEstudiante repositorioE) : base(repositorioE)
{
}

    public List<Estudiante> Ejecutar(){
         return RepositorioEstudiante.ListarEstudiantes();
    }
}