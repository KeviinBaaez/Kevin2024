namespace Kevin2024.Entidades.Entidades
{
    public class Postre : Productos
    {
        public int? MarcaId { get; set; }
        public Marcas? Marcas { get; set; }
    }
}
