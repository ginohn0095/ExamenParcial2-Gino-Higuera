using System.ComponentModel.DataAnnotations;
namespace ExamenParcial2_Gino_Higuera.Models
{
    public class Paciente
    {
        #region Paciente 
        //Modelo de Paciente
        [Key]
        public int? PacienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public ICollection<Cita> ?Citas { get; set; }
        #endregion
    }
}
