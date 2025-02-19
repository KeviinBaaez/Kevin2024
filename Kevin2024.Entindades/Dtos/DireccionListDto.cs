namespace Kevin2024.Entidades.Dtos
{
    public class DireccionListDto
    {
        public int DireccionId { get; set; }
        public string? TipoDireccion { get; set; }
        public string Calle { get; set; } = null!;
        public string Altura { get; set; } = null!;
        public string? Entre1 { get; set; }
        public string? Entre2 { get; set; }

        public override string ToString()
        {
            return $"{Calle} {Altura}";
        }


    }
}
