using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades.ViewModels
{
    public class DireccionConTipoVm
    {
        public Direccion? Direccion { get; set; }
        public TipoDireccion? TipoDireccion { get; set; }

        public DireccionConTipoVm()
        {
            
        }
        public DireccionConTipoVm(Direccion direccion, TipoDireccion? tipoDireccion)
        {
            Direccion = direccion;
            TipoDireccion = tipoDireccion;
        }

        public override string ToString()
        {
            return $"{Direccion.Calle} {Direccion.Altura}, {TipoDireccion!.Descripcion}";
        }
    }
}
