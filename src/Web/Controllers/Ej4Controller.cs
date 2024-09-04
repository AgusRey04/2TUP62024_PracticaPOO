using System;
using Microsoft.AspNetCore.Mvc;
using Web.Ej4;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{

    [HttpPost("ConCombustible")]
    public ActionResult CrearCocheCombustible(int combustible)
    {
        Coche coche = new(combustible);
        coche.Conducir();
        return Ok($"{coche.Texto}");
    }
    [HttpPost("SinCombustible")]
    public ActionResult CrearCocheSinCombustible(int combustible)
    {
        Coche coche = new(0);
        coche.CargarCombustible(combustible);
        coche.Conducir();
        return Ok($"{coche.Texto}");
    }
}
