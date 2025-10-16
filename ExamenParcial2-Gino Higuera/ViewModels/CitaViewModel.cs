namespace ExamenParcial2_Gino_Higuera.ViewModels
{
    public class CitaViewModel
    {
        #region CitaViewModel
        //ViewModel de Cita para mostrar datos combinados
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Estado { get; set; }

        public int PacienteId { get; set; }
        public string? Paciente { get; set; }

        public int DoctorId { get; set; }
        public string? Doctor { get; set; }
        #endregion
    }
}
