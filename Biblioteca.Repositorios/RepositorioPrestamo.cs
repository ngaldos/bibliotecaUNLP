using System.Data.Common;
using System.Text.Json.Serialization;
using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;

namespace Biblioteca.Repositorios;

public class RepositorioPrestamo : IRepositorioPrestamo {

public void RealizarPrestamo(Prestamo prestamo){
    
    using (var db = new BibliotecaContext()){
        if (prestamo != null && prestamo?.Idlibro != null && prestamo?.Idpersona != null){
            var libro = db.Libros.Where(l => l.Id == prestamo.Idlibro).SingleOrDefault();
            var persona = db.Personas.Where((p)=> p.id == prestamo.Idpersona).SingleOrDefault();
            var prestamoAux = db.Prestamos.Where((p)=> p.Idlibro == prestamo.Idlibro && p.Idpersona == prestamo.Idpersona && p.estado == null).SingleOrDefault();
            if (prestamoAux != null && prestamoAux.estado == null)
                throw new Exception($"El prestamo del libro {libro?.titulo}, {libro?.autor}; a nombre de {persona?.nombre} {persona?.apellido} ya existe y se encuentra pendiente de devolucion...  ---  PersonaID -> {prestamoAux.Idpersona} // LibroID -> {prestamoAux.Idlibro}");
            else{
                if (persona == null || libro == null)   
                    throw new Exception($"El prestamo del libro {libro?.titulo}, {libro?.autor}; a nombre de {persona?.nombre} {persona?.apellido} no existe.");
                if (libro.numeroEjemplar >=1 ){
                    libro.numeroEjemplar--;
                    db.Add(prestamo);
                    db.SaveChanges();
                }else if (libro.numeroEjemplar == 0){
                    throw new Exception("No hay ejemplares disponibles.");
                }
            }

            
    }else throw new Exception("No se recibio un prestamo.");
    }


}
     public void DevolverLibro(Prestamo devolucion){
        try{
            using (var db = new BibliotecaContext()){
            if (devolucion != null && devolucion?.Idlibro != null && devolucion?.Idpersona != null){
                var prestamoDb = db.Prestamos.Where(p => p.Id == devolucion.Id).SingleOrDefault(); // Busco si existe el prestamo en la BDD
                if (prestamoDb == null) throw new Exception("El prestamo a devolver no existe en la base de datos.");                
                var libroAuxDb = db.Libros.Where(l => l.Id == devolucion.Idlibro).SingleOrDefault(); // Busco si existe el libro en la BDD
                if (libroAuxDb == null) throw new Exception("El libro del prestamo que se quiere devolver no existe en la base de datos.");
                var personaAuxDb = db.Personas.Where(p => p.id == devolucion.Idpersona).SingleOrDefault(); // Busco si existe la persona en la BDD
                if (personaAuxDb == null) throw new Exception("La persona a la que esta asociada el prestamo no existe en la base de datos.");
                
                libroAuxDb.numeroEjemplar ++;
                prestamoDb.estado= devolucion.estado;
                db.SaveChanges();
                
            }else throw new Exception("El prestamo a devolver es invalido.");
        }
        }catch (Exception ex){Console.WriteLine(ex.Message);}
       
     }


public Prestamo ObtenerPrestamo(int id){
    try{
        using (var db = new BibliotecaContext()){
            var aux = db.Prestamos.Where(p => p.Id == id).SingleOrDefault();
            if (aux != null)    return aux;
            else throw new Exception($"No existe el prestamo con ID = {id}.");
        }
        
    }catch {throw;}
}

 public List<Prestamo> ListarPrestamos(){
      
     List<Prestamo> p ;
        try{
            using (var db = new BibliotecaContext()){
                if (db.Prestamos.Count() >  0)  p = db.Prestamos.ToList();
                else p = new List<Prestamo>{};
            }
            p = p.OrderBy(x => x.Id).ToList();
            return p;
        }catch{
            throw;
        }
    }
}