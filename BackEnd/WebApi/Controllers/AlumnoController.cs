using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnoController : ControllerBase
    {
        private readonly AlumnoDomain _alumnoDomain;

        public AlumnoController(AlumnoDomain alumnoDomain)
        {
            _alumnoDomain = alumnoDomain;
        }

        [HttpGet("ObtenerAlumno")]
        public IActionResult ObtenerAlumno()
        {
            var alumnos = _alumnoDomain.ObtenerAlumno();
            return Ok(alumnos);
        }

        [HttpPost("InsertarAlumno")]
        public IActionResult InsertarAlumno(Alumno oAlumno)
        {
            var id = _alumnoDomain.InsertarAlumno(oAlumno);
            return Ok(id);
        }
    }
}
