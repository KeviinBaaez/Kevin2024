namespace Kevin2024.Entidades.Dtos
{
    public class PostresListDto : ProductosListDto
    {
        public string Sabor { get; set; } = null!;
        public decimal PrecioCosto { get; set; }
        public int NivelDeReposicion { get; set; }
    }
}
