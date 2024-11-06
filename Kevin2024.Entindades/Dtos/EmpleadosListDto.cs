namespace Kevin2024.Entidades.Dtos
{
    public class EmpleadosListDto
    {
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni {  get; set; }
        public double Salario { get; set; }
        public bool Suspendido { get; set; }
    }
}
