namespace Biblioteca.Aplicacion.Entidades;

public class Prestamo {

    public int  Id { get; set;}
    public int Idpersona {get; set;}
     public int Idlibro   {get; set;}
    public string? fechaPrestamo { get; set; }
    public string?  fechaDevolucion {get; set; }
    public string? estado { get; set;}


    public Prestamo(int  per, int  libro, string fechaPrestamo, string fechaDevol){
        this.Idpersona = per;
        this.Idlibro = libro;
        this.fechaPrestamo = fechaPrestamo;
        this.fechaDevolucion = fechaDevol;
        this.estado= null;
    }

    

    public Prestamo(){}

}

