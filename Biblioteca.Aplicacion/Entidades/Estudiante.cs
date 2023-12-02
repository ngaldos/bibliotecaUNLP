namespace Biblioteca.Aplicacion.Entidades;

public class Estudiante : Persona{
    public int nroAlumno { get; set;}
    public String? carrera {get; set; } = "";


    public Estudiante(int num_Carnet, string nombre, string apellido, string direccion, string facu, string telefono, string correo, int num_alumno,string carrera):base(num_Carnet,nombre,apellido,direccion,facu,telefono,correo){
        this.carrera= carrera;
        this.nroAlumno = num_alumno;

    }

    public Estudiante(){}


    public override string ToString()
    {
        return base.ToString() + $"(Numero de Alumno{nroAlumno}) (Carrera:{carrera})";
    }
}