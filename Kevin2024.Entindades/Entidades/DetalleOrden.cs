namespace Kevin2024.Entidades.Entidades
{
    public class DetalleOrden
    {
        public int DetalleOrdenId { get; set; }
        public int OrdenId { get; set; }
        public int? ProductoId { get; set; }
        public int? ComboId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Productos? Productos { get; set; }
        public Combo? Combo { get; set; }
    }
}
