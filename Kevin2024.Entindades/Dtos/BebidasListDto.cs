namespace Kevin2024.Entidades.Dtos
{
    public class BebidasListDto : ProductosListDto
    {
        public string Sabor { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public int NivelDeReposicion { get; set; }
    }
}
