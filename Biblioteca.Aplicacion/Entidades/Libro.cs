namespace Biblioteca.Aplicacion.Entidades;

public class Libro {
    public int  Id { get;set;}
    public String? titulo {get; set; } = "";
    public String? autor { get; set; } = "";
    public String? añoPublicacion { get; set; } = "";
    public String? genero {get; set; } = "";
    public int numeroEjemplar { get; set; }

    public int numeroEjemplarConst {get;  set;}


    public Libro(String titulo, String autor,String añoPubli, String genero, int cantEjemplar){
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.añoPublicacion = añoPubli;
        this.numeroEjemplar = cantEjemplar;
        this.numeroEjemplarConst = cantEjemplar;
    }

    public Libro(){
    }

    public override string ToString()
    {
        return  $"IDLibro: { Id } Titulo del Libro: { titulo } Autor: { autor } Año de Publicacion: { añoPublicacion } Cantidad de ejemplares disponibles: { numeroEjemplar } Cantidad de ejemplares totales {numeroEjemplarConst}.";
    }
}

