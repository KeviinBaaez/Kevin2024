namespace Kevin2024.Entidades.Entidades
{
    public class Combo : Productos
    {
        public List<DetallesCombos> DetallesCombos { get; set; } = new List<DetallesCombos>();

        public void Agregar(DetallesCombos detalleCombo)
        {
            var detalles = DetallesCombos.FirstOrDefault(d => d.ProductoId == detalleCombo.ProductoId);
            if (detalles is null)
            {
                DetallesCombos.Add(detalleCombo);
            }
            else
            {
                detalles.Cantidad += detalleCombo.Cantidad;
            }
        }
        public bool Existe(DetallesCombos detalleCombo)
        {
            return DetallesCombos.Any(d => d.ProductoId == detalleCombo.ProductoId);
        }
    }
}
