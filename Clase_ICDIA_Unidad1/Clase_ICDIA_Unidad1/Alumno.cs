namespace Clase_ICDIA_Unidad1;

public class Alumno
{
    private string nombre;
    private string matricula;
    private int cal1;
    private int cal2;
    private int cal3;
    private double promedio;

    public Alumno(string matricula, string nombre)
    {
        this.matricula = matricula;
        this.nombre = nombre;
    }

    public string Matricula
    {
        get => matricula; 
        set => matricula = value;
    }

    public string ToString()
    {
        string cad = " Nombre: "+nombre +
                     "\n Matricula: "+matricula +
                     "\n Promedio: "+promedio;

        return cad;
    }


}