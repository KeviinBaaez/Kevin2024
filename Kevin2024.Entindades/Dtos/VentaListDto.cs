using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Entidades.Dtos
{
    public class VentaListDto
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }
        public string? Cliente { get; set; }
        public int TipoOrdenId { get; set; }
        public string? TipoDeOrden { get; set; }
    }
}
