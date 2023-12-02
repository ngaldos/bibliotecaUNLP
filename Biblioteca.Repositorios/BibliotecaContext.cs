namespace Biblioteca.Repositorios;

using Biblioteca.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;



public class BibliotecaContext : DbContext
{

#nullable disable
public DbSet<Persona> Personas { get; set; }
public DbSet<Docente> Docentes { get; set; }
public DbSet<Estudiante> Estudiantes { get; set; }
public DbSet<Libro> Libros { get; set; }
public DbSet<Prestamo> Prestamos { get; set; }
#nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Biblioteca.sqlite");
    }


}