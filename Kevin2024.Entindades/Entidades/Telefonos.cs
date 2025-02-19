namespace Kevin2024.Entidades.Entidades
{
    public class Telefonos
    {
        public int TelefonoId { get; set; }
        public string Numero { get; set; } = null!;

        public List<ClienteTelefono> ClienteTelefonos { get; set; } = new List<ClienteTelefono>();
        public override string ToString()
        {
            return $"{Numero}";
        }
    }
}
