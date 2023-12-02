namespace Biblioteca.Repositorios;

using System.Data.Common;
using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.UseCases;

public class RepositorioDocente : IRepositorioDocente {
   
 
    public Docente ObtenerDocente (int id){
        try
        {
            using(var db = new BibliotecaContext()){
                var aux = db.Docentes.Where(d => d.id == id).SingleOrDefault();
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
    public void AgregarDocente(Docente docente){
        try{
            using (var db = new BibliotecaContext()){
                if (docente != null){
                    var aux = db.Docentes.Where(d => d.id == docente.id).SingleOrDefault();
                    if (aux != null) throw new Exception($"El docente con ID = {docente.id} ya existe en la base de datos.");
                    db.Add(docente);
                    db.SaveChanges();
                }else throw new Exception("El docente recibido es invalido.");
            }
        }catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
           

    public void ModificarDocente(Docente docente){
         using (var db = new BibliotecaContext()){
            var doncenteDB = db.Docentes.Where(e => e.id == docente.id).SingleOrDefault();
            if (doncenteDB != null)
            {
                doncenteDB.añoInicio = docente.añoInicio; //se modifica el registro en memoria
                doncenteDB.apellido = docente.apellido;
                doncenteDB.correo = docente.correo;
                doncenteDB.direccion= docente.direccion;
                doncenteDB.facultad = docente.facultad;
                doncenteDB.nombre = docente.nombre;
                doncenteDB.nroMatricula = docente.nroMatricula;
                doncenteDB.numero_Carnet = docente.numero_Carnet;
                doncenteDB.telefono = docente.telefono;
        
            }else throw new Exception("El docente no se encontro en la base de datos.");
            db.SaveChanges();
        }
    }

    public void EliminarDocente(int idDoc)
{
    try
    {
        using (var db = new BibliotecaContext()){
            var docenteBorrar = db.Docentes.Where(a => a.id == idDoc).SingleOrDefault();
            if (docenteBorrar != null){
                var prestamos = db.Prestamos.Where(p => p.Idpersona == idDoc).ToList();
                prestamos.ForEach((p) => {
                    if (p.estado == null){
                        var libroAux = db.Libros.Where(l => l.Id == p.Idlibro).SingleOrDefault();
                        if (libroAux != null){
                            libroAux.numeroEjemplar++;
                        }
                    }
                    db.Remove(p);
                });
                db.Remove(docenteBorrar); 
                db.SaveChanges();
            }else{
                throw new Exception("El docente a borrar no existe en la base de datos.");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


    public List<Docente> ListarDocentes(){
        try{
            List<Docente> d ;
            using (var db = new BibliotecaContext()){
                d = db.Docentes.ToList();
            }
            return d;
        }catch {throw;}
    
    }

}