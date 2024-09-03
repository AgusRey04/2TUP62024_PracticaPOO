
using Microsoft.AspNetCore.Mvc;
using Web.Ej3;
namespace Web.Controllers;


[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{

    [HttpPost("persona")]
    public ActionResult CrearPersona(string nombre)
    {
        Persona persona = new(nombre);
        return Ok(persona.Saludar());
    }
    [HttpPost("Estudiante")]
    public ActionResult CrearEstudiant(string nombre, int edad)
    {
        Estudiante persona = new(nombre);
        persona.SetEdad(edad);
        return Ok($"{persona.Saludar()} {persona.MostrarEdad()}");
    }

    [HttpPost("Profesor")]
    public ActionResult CrearProfesor(string nombre, int edad)
    {
        Profesor persona = new(nombre);
        persona.SetEdad(edad);
        return Ok($"{persona.Saludar()} {persona.Explicar()} ");
    }
}