using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Entidades.Entidades
{
    public class OrdenPedido
    {
        public int OrdenId { get; set; }
        public int? ClienteId { get; set; }
        public int TipoOrdenId { get; set; }
        public int EstadoOrdenId { get; set; }
        public int EstadoPagoId { get; set; }
        public DateTime FechaOrden { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }

        public List<DetalleOrden> Detalles { get; set; } = new List<DetalleOrden>();

        public Cliente? Cliente { get; set; }
        public TipoOrden? TipoOrden { get; set; }
        public EstadoOrden? EstadoOrden { get; set; }
        public EstadoPago? EstadoPago { get; set; }

        public void AgregarDetalleOrden(DetalleOrden detalle)
        {

            if (detalle.ProductoId == detalle.ComboId)
            {
                detalle.ProductoId = null;
            }
            var detalleVenta = Detalles.FirstOrDefault(
                p => p.ProductoId == detalle.ProductoId && p.ComboId == detalle.ComboId);
            if (detalleVenta == null)
            {
                Detalles.Add(detalle);
            }
            else
            {
                detalleVenta.Cantidad += detalle.Cantidad;
            }
        }
        public void EliminarDetalleOrden(DetalleOrden detalle)
        {

            if (detalle.ProductoId == detalle.ComboId)
            {
                detalle.ProductoId = null;
            }
            var detalleVenta = Detalles.FirstOrDefault(
                p => p.ProductoId == detalle.ProductoId && p.ComboId == detalle.ComboId);
            if (detalleVenta == null)
            {
                Detalles.Add(detalle);
            }
            else
            {
                Detalles.Remove(detalle);
            }
        }
        public decimal GetTotal() => Detalles.Sum(dv => dv.Cantidad * dv.Precio);
        public int GetCantidad() => Detalles.Sum(dv => dv.Cantidad);

        public void Borrar(DetalleOrden dt)
        {
            Detalles.Remove(dt);
        }
    }
}
