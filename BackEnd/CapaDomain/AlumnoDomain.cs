using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class AlumnoDomain
    {
        private readonly AlumnoRepository _alumnoRepository;

        public AlumnoDomain(AlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        public IEnumerable<Alumno> ObtenerAlumno()
        {
            return _alumnoRepository.ObtenerAlumno();
        }

        public int InsertarAlumno(Alumno oAlumno)
        {
            try
            {
                return _alumnoRepository.InsertarAlumno(oAlumno);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
