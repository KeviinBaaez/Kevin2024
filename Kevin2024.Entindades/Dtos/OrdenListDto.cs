using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades.Dtos
{
    public class OrdenListDto
    {
        public int OrdenId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaOrden { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }
        public string? Cliente { get; set; }
        public int TipoOrdenId { get; set; }
        public string? TipoDeOrden { get; set; }
        public int EstadoOrdenId { get; set; }
        public string? EstadoOrden { get; set; }
        public int EstadoPagoId { get; set; }
        public string? EstadoPago { get; set; }
    }
}
