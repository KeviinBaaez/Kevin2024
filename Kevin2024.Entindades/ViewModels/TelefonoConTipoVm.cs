using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Entidades.ViewModels
{
    public class TelefonoConTipoVm
    {
        public Telefonos Telefono { get; set; }
        public TipoTelefono? TipoTelefono { get; set; }

        public TelefonoConTipoVm(Telefonos telefono, TipoTelefono? tipoTelefono)
        {
            Telefono = telefono;
            TipoTelefono = tipoTelefono;
        }

        public override string ToString()
        {
            return $"{Telefono.ToString()} - ({TipoTelefono?.Descripcion})";
        }
    }
}
