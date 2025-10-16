using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2_Gino_Higuera.Models
{
    public class Doctor
    {
        #region Doctor
        //Modelo de Doctor
        [Key]
        public int DoctorId { get; set; }
        public string? Nombre { get; set; }
        public string? Especialidad { get; set; }

        public ICollection<Cita>? Citas { get; set; }
        #endregion
    }
}
