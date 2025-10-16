using ExamenParcial2_Gino_Higuera.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ConsultaController : Controller
{

    private readonly AplicacionDbContext _context;

    public ConsultaController(AplicacionDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    #region ObtenerCitas
    //Metodo para obtener todas las citas con detalles del paciente y doctor
    public async Task<IActionResult> ObtenerCitas()
    {
        var citas = await _context.Citas
            .Include(c => c.Paciente)
            .Include(c => c.Doctor)
            .Select(c => new {
                c.CitaId,
                Fecha = c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                Paciente = c.Paciente.Nombre + " " + c.Paciente.Apellido,
                Doctor = c.Doctor.Nombre,
                Especialidad = c.Doctor.Especialidad,
                Estado = c.Estado
            }).ToListAsync();

        return Json(citas);
    }
    #endregion
    #region FiltrarCitas
    //Metodo para filtrar citas por paciente
    public async Task<IActionResult> FiltrarPorPaciente(int pacienteId)
    {
        var citas = await _context.Citas
            .Include(c => c.Paciente)
            .Include(c => c.Doctor)
            .Where(c => c.PacienteId == pacienteId)
            .Select(c => new {
                c.CitaId,
                Fecha = c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                Paciente = c.Paciente.Nombre + " " + c.Paciente.Apellido,
                Doctor = c.Doctor.Nombre,
                Especialidad = c.Doctor.Especialidad,
                Estado = c.Estado
            }).ToListAsync();

        return Json(citas);
    }
    #endregion
    #region FiltrarCitas
    //Metodo para filtrar citas por doctor
    public async Task<IActionResult> FiltrarPorDoctor(int doctorId)
    {
        var citas = await _context.Citas
            .Include(c => c.Paciente)
            .Include(c => c.Doctor)
            .Where(c => c.DoctorId == doctorId)
            .Select(c => new {
                c.CitaId,
                Fecha = c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                Paciente = c.Paciente.Nombre + " " + c.Paciente.Apellido,
                Doctor = c.Doctor.Nombre,
                Especialidad = c.Doctor.Especialidad,
                Estado = c.Estado
            }).ToListAsync();

        return Json(citas);
    }
    #endregion
}
