namespace Biblioteca.Aplicacion.Entidades;

public class Docente : Persona {
    public int nroMatricula { get; set;}
    public String? añoInicio { get; set;}

    public Docente(int num_Carnet, string nombre, string apellido, string direccion, string facu, string telefono, string correo, int num_Matricula, String añoInicio)
        :base(num_Carnet,nombre,apellido,direccion,facu,telefono,correo)
    {
        this.nroMatricula= num_Matricula;
        this.añoInicio = añoInicio;
        

    }

    public Docente(){}

    

    public override string ToString()
    {
        return base.ToString() + $" (Numero de Matricula:{nroMatricula}) (Año de Incio:{añoInicio})";
    }
}