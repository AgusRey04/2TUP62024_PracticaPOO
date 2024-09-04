using System;

namespace Web.Ej4;

public class Coche : IVehiculo
{
    public int Combustible { get; set; }
    public string? Texto { get; set; }

    public Coche(int combustible)
    {
        Combustible = combustible;
    }
    public Coche()
    {
        Combustible = 0;
    }

    public void Conducir()
    {
        if (Combustible > 0)
        {
            Texto = "El coche está siendo manejado";
        }
        else
        {
            Texto = "El coche no tiene combustible";
        }

    }
    public bool CargarCombustible(int combustible)
    {
        if (combustible > 0)
        {
            Combustible = Combustible + combustible;
            return true;
        }
        else
        {
            return false;
        }
    }

}
