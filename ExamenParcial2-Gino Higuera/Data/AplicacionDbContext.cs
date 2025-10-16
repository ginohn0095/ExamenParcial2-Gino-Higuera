using Microsoft.EntityFrameworkCore;
using ExamenParcial2_Gino_Higuera.Models;



namespace ExamenParcial2_Gino_Higuera.Data
{
    public class AplicacionDbContext:DbContext
    {
        #region Constructores
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Cita> Citas { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Pacientes
            //Datos de semilla de pacientes
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente { PacienteId = 1, Nombre = "Juan", Apellido = "Perez" },
                new Paciente { PacienteId = 2, Nombre = "Maria", Apellido = "Lopez" },
                new Paciente { PacienteId = 3, Nombre = "Carlos", Apellido = "Sanchez" },
                new Paciente { PacienteId = 4, Nombre = "Ana", Apellido = "Martinez" },
                new Paciente { PacienteId = 5, Nombre = "Luis", Apellido = "Gomez" }
            );
            #endregion
            #region Doctores
            //Datos de semilla de doctores
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, Nombre = "Dr. Smith", Especialidad = "Cardiología" },
                new Doctor { DoctorId = 2, Nombre = "Dr. Johnson", Especialidad = "Pediatría" },
                new Doctor { DoctorId = 3, Nombre = "Dr. Brown", Especialidad = "Dermatología" }
            );
            #endregion
            #region Citas
            //Datos de semilla de citas
            modelBuilder.Entity<Cita>().HasData(
                new Cita { CitaId = 1, Fecha = DateTime.Now.AddDays(1), Estado = "Pendiente", PacienteId = 1, DoctorId = 1 },
                new Cita { CitaId = 2, Fecha = DateTime.Now.AddDays(2), Estado = "Confirmada", PacienteId = 2, DoctorId = 1 },
                new Cita { CitaId = 3, Fecha = DateTime.Now.AddDays(3), Estado = "Cancelada", PacienteId = 3, DoctorId = 2 },
                new Cita { CitaId = 4, Fecha = DateTime.Now.AddDays(4), Estado = "Pendiente", PacienteId = 4, DoctorId = 2 },
                new Cita { CitaId = 5, Fecha = DateTime.Now.AddDays(5), Estado = "Confirmada", PacienteId = 5, DoctorId = 3 },
                new Cita { CitaId = 6, Fecha = DateTime.Now.AddDays(6), Estado = "Pendiente", PacienteId = 1, DoctorId = 3 },
                new Cita { CitaId = 7, Fecha = DateTime.Now.AddDays(7), Estado = "Confirmada", PacienteId = 2, DoctorId = 2 },
                new Cita { CitaId = 8, Fecha = DateTime.Now.AddDays(8), Estado = "Cancelada", PacienteId = 3, DoctorId = 1 },
                new Cita { CitaId = 9, Fecha = DateTime.Now.AddDays(9), Estado = "Pendiente", PacienteId = 4, DoctorId = 3 },
                new Cita { CitaId = 10, Fecha = DateTime.Now.AddDays(10), Estado = "Confirmada", PacienteId = 5, DoctorId = 2 }
            );
            #endregion
        }

    }
}
