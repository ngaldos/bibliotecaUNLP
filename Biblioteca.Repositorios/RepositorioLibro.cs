namespace Biblioteca.Repositorios;

using System.Security.Cryptography.X509Certificates;
using Biblioteca.Aplicacion;
using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;

public class RepositorioLibro : IRepositorioLibro {

    public Libro ObtenerLibro (int id){
        try
        {
            using(var db = new BibliotecaContext()){
                var aux = db.Libros.Where(l=> l.Id == id).SingleOrDefault();
                if (aux != null){
                    return aux;
                }else throw new Exception("No existe ese docente.");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void AgregarLibro (Libro libro){
        using (var db = new BibliotecaContext()){
            if (libro != null){
                db.Add(libro);
                db.SaveChanges();
            }else throw new Exception("Libro invalido, no se puede agregar.");
        }
       
    }

    public void ModificarLibro(Libro libro){
    
       try{
            using (var db = new BibliotecaContext()){
            if (libro != null){
                var libroDB = db.Libros.Where(l => l.Id == libro.Id).SingleOrDefault();
                if (libroDB != null){
                    libroDB.titulo = libro?.titulo;
                    libroDB.autor = libro?.autor;
                    libroDB.añoPublicacion = libro?.añoPublicacion;
                    libroDB.genero= libro?.genero;
                    //Doble verificacion requerida por un warning.
                    if (libro!= null)  libroDB.numeroEjemplar = libro.numeroEjemplar;  //Triple verificacion requerida por un warning.
                    if (libro!= null) libroDB.numeroEjemplarConst = libro.numeroEjemplarConst;
                    db.SaveChanges();
                }else throw new Exception("No existe ese libro.");

            }else throw new Exception("Libro proporcionado invalido, no se puede modificar");
       }
       }catch (Exception ex){
            Console.WriteLine(ex.Message);
       }

        
           
    }

    public void EliminarLibro(int idLibro) {

        try{
            using (var db = new BibliotecaContext()){
                var libroBorrar = db.Libros.Where(a => a.Id == idLibro).SingleOrDefault();
                if (libroBorrar != null){
                    var prestamos = db.Prestamos.Where((p)=> p.Idlibro == idLibro).ToList();
                    foreach (Prestamo p in prestamos){
                        db.Remove(p);
                    }
                    db.Remove(libroBorrar);
                    db.SaveChanges();
                }else throw new Exception("No existe el libro a borrar");
            }
        }catch{
            throw;
        }
    }


    public List<Libro> ListarLibros(){
        List<Libro> d ;
        try{
            using (var db = new BibliotecaContext()){
            d = db.Libros.ToList();
            return d;
        }
        }catch{
            throw;
        }
    }
}