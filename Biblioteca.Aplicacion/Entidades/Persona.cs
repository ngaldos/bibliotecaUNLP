namespace Biblioteca.Aplicacion.Entidades;

public abstract class  Persona{

     public int id { get;set;}
     public int numero_Carnet { get; set; }
     public String? nombre{ get; set; } = "";
     public String? apellido { get; set;} = "";
     public String? direccion { get; set; } = "";
     public String? facultad { get; set; } ="";
     public String? telefono { get; set; } = "";
     public String? correo { get; set; } = "";
     public List<Prestamo>? prestamos {get; set;}


     public Persona(int num_Carnet, string nombre, string apellido, string direccion, string facu, string telefono, string correo)
     {
        this.numero_Carnet = num_Carnet;
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion =direccion;
        this.facultad = facu;
        this.telefono = telefono;
        this.correo = correo;
     }

     public Persona(){
     }


    public override string ToString()
    {
        return $" (ID:{id})  (Numero de Carnet:{numero_Carnet}) (Nombre:{nombre}) (Apellido:{apellido})  (Direccion:{direccion}) (Facultad:{facultad}) (Telefono:{telefono}) (Correo:{correo}) ";
    }

}