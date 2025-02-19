namespace Kevin2024.Entidades.Entidades
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public int? ProductoId { get; set; }
        public int? ComboId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Productos? Productos { get; set; }
        public Combo? Combo { get; set; }
    }
}
