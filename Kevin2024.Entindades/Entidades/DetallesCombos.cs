namespace Kevin2024.Entidades.Entidades
{
    public class DetallesCombos
    {
        public int DetalleComboId { get; set; }
        public int ComboId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public Combo? Combo { get; set; }
        public Productos? Producto { get; set; }
    }
}
