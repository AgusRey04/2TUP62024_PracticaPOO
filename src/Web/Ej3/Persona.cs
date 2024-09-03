using System;

namespace Web.Ej3;

public class Persona
{
    protected string Nombre { get; set; }
    protected int Edad { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;

    }

    public int SetEdad(int edad)
    {
        Edad = edad;
        return Edad;
    }
    public virtual string Saludar()
    {
        return $"Hola!";
    }

}
