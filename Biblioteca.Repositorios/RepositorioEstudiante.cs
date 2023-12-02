namespace Biblioteca.Repositorios;

using Biblioteca.Aplicacion.Interfaces;
using Biblioteca.Aplicacion.Entidades;



public class RepositorioEstudiante : IRepositorioEstudiante {
   

    public void AgregarEstudiante (Estudiante estudiante){
         using (var db = new BibliotecaContext()){
            if(estudiante != null){
                db.Add(estudiante);
                db.SaveChanges();
            }else throw new Exception("El estudiante a agregar es invalido.");
        }
    }

    public void ModificarEstudiante(Estudiante estudiante){
        
        using (var db = new BibliotecaContext()){
            if (estudiante != null){

            var estudianteDB = db.Estudiantes.Where(e => e.id == estudiante.id).SingleOrDefault();
            if (estudianteDB != null)
            {
                estudianteDB.nombre = estudiante.nombre;  // poner todos los campos del estudiante //se modifica el registro en memoria
                estudianteDB.apellido = estudiante.apellido;
                estudianteDB.carrera= estudiante.carrera;
                estudianteDB.correo= estudiante.correo;
                estudianteDB.direccion= estudiante.direccion;
                estudianteDB.facultad = estudiante.facultad;
                estudianteDB.nombre = estudiante.nombre;
                estudianteDB.nroAlumno = estudiante.nroAlumno;
                estudianteDB.numero_Carnet = estudiante.numero_Carnet;
                estudianteDB.telefono = estudiante.telefono;
            }else throw new Exception("El estudiante a modificar no existe en la base de datos.");
              db.SaveChanges();
            }else throw new Exception("El estudiante recibido es invalido.");
        }

    }

    public void EliminarEstudiante(int idEstudiante) {
        try{
            using (var db = new BibliotecaContext()){
            var estudianteBorrar = db.Estudiantes.Where(a => a.id == idEstudiante).SingleOrDefault();
            if (estudianteBorrar != null){    
                var prestamos = db.Prestamos.Where(p => p.Idpersona == idEstudiante).ToList();
                prestamos.ForEach((p)=> {
                    if (p.estado == null){
                        var libroAux = db.Libros.Where(l => l.Id == p.Idlibro).SingleOrDefault();
                        if (libroAux != null){
                            libroAux.numeroEjemplar++;
                        }
                    }
                    db.Remove(p);
                });
                db.Remove(estudianteBorrar);
                db.SaveChanges();
            }else throw new Exception("El estudiante a borrar no existe en la base de datos.");
        }

        }catch {throw;}
                
       
    }


    public List<Estudiante> ListarEstudiantes(){
       List<Estudiante> d ;
        using (var db = new BibliotecaContext()){
            d = db.Estudiantes.ToList();
        }
        return d;
    }
    public Estudiante ObtenerEstudiante (int id){
        try
        {
            using(var db = new BibliotecaContext()){
                var aux = db.Estudiantes.Where(d => d.id == id).SingleOrDefault();
                if (aux != null){
                    return aux;
                }else throw new Exception("No existe ese docente.");
            }
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}