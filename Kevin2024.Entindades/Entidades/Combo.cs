
namespace Kevin2024.Entidades.Entidades
{
    public class Combo : Productos
    {
        public List<DetallesCombos> DetallesCombos { get; set; } = new List<DetallesCombos>();

        public void Agregar(DetallesCombos detalle)
        {
            var detallesEnCaja = DetallesCombos.FirstOrDefault(d => d.ProductoId == detalle.ProductoId);
            if (detallesEnCaja is null)
            {
                DetallesCombos.Add(detalle);
            }
            else
            {
                detallesEnCaja.Cantidad += detalle.Cantidad;
            }
        }

        public void Eliminar(DetallesCombos detalle)
        {
            DetallesCombos.Remove(detalle);
        }

        public bool Existe(DetallesCombos detalleCombo)
        {
            return DetallesCombos.Any(d => d.ProductoId == detalleCombo.ProductoId);
        }
    }
}
