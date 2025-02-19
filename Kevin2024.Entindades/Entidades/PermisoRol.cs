namespace Kevin2024.Entidades.Entidades
{
    public class PermisoRol
    {
        public int PermisoRolId { get; set; }
        public int PermisoId { get; set; }
        public int RolId { get; set; }
        public Permiso? Permiso { get; set; }
        public Rol? Rol { get; set; }
    }
}
