using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades
{
    public class Productos
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? MarcaId { get; set; }
        public string? Sabor { get; set; } 
        public decimal CodBarras { get; set; }
        public int? TamanioId { get; set; }
        public int CategoriaId { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int NivelDeReposicion { get; set; }
        public string? Imagen {  get; set; }
        public bool Suspendido { get; set; }
        public int EnPedido { get; set; }
        public TiposDeDatos? TiposDeDatos { get; set; }


    }
}
