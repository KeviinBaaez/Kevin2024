using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades.Dtos
{
    public class ProductosListDto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Marca { get; set; }
        public decimal CodBarras { get; set; }
        public string? Tamanio {  get; set; }
        public int CategoriaId { get; set; }
       public string? Categoria { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Suspendido { get; set; }
    }
}
