using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenParcial2_Gino_Higuera.Models
{
    public class Cita
    {
        #region Cita
        //Modelo de Cita
        [Key]
        public int CitaId { get; set; }

        public DateTime Fecha { get; set; }

        public string? Estado { get; set; }

        //Relación con Paciente
        public int PacienteId { get; set; }

        [ForeignKey("PacienteId")]
        public Paciente? Paciente { get; set; }

        //Relación con Doctor
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }
        #endregion
    }
}
