using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int? ClienteId { get; set; }
        public int TipoVentaId { get; set; }
        public int EstadoPagoId { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
        public Cliente? Cliente { get; set; }
        public TipoOrden? TipoVenta { get; set; }
        public EstadoPago? EstadoPago { get; set; }


        public void AgregarDetalleVenta(DetalleVenta detalle)
        {

            if(detalle.ProductoId == detalle.ComboId)
            {
                detalle.ProductoId = null;
            }
            var detalleVenta = Detalles.FirstOrDefault(
                p => p.ProductoId == detalle.ProductoId && p.ComboId == detalle.ComboId);
            if(detalleVenta == null)
            {
                Detalles.Add(detalle);
            }
            else
            {
                detalleVenta.Cantidad += detalle.Cantidad;
            }
        }
        public void EliminarDetalleVenta(DetalleVenta detalle)
        {

            if (detalle.ProductoId == detalle.ComboId)
            {
                detalle.ProductoId = null;
            }
            var detalleVenta = Detalles.FirstOrDefault(
                p => p.ProductoId == detalle.ProductoId && p.ComboId == detalle.ComboId);
            if (detalleVenta == null)
            {
                Detalles.Remove(detalle);
            }
            else
            {
                detalleVenta.Cantidad += detalle.Cantidad;
            }
        }

        public decimal GetTotal() => Detalles.Sum(dv => dv.Cantidad * dv.Precio);
        public int GetCantidad() => Detalles.Sum(dv => dv.Cantidad);
    }
}
