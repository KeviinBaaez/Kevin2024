namespace Kevin2024.Entidades.Entidades
{
    public class ClienteTelefono
    {
        public int ClienteId { get; set; }
        public int TelefonoId { get; set; }
        public int TipoTelefonoId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public Telefonos Telefono { get; set; } = null!;
        public TipoTelefono TipoTelefono { get; set; } = null!;
    }
}
