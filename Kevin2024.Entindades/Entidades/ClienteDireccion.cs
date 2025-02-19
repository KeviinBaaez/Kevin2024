using Kevin2024.Entidades.ViewModels;

namespace Kevin2024.Entidades.Entidades
{
    public class ClienteDireccion
    {
        public int ClienteId { get; set; }
        public int DireccionId { get; set; }
        public int TipoDireccionId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public Direccion Direccion { get; set; } = null!;
        public TipoDireccion TipoDireccion { get; set; } = null!;
    }
}
