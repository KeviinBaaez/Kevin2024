using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades.Dtos
{
    public class ComboListDto
    {
        public int ComboId { get; set; }
        public string Nombre { get; set; } = null!;
        public int? TamanioId { get; set; }
        public string? Tamanio { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Suspendido { get; set; }

        public TiposDeDatos? TiposDeDatos { get; set; }
    }
}
