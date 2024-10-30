using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades
{
    public class Bebidas : Productos
    {
        public int MarcaId { get; set; }
        public Marcas? Marcas { get; set; }
    }
}
