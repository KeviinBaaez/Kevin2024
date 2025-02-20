﻿namespace Kevin2024.Entidades.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int Documento { get; set; }
        public string Apellido { get; set; } = null!;
        public string Nombres { get; set; } = null!;

        public string NombreCompleto { get => $"{Apellido} {Nombres}"; }
        public List<ClienteDireccion> ClienteDirecciones { get; set; } = new List<ClienteDireccion>();
        public List<ClienteTelefono> ClienteTelefonos { get; set; } = new List<ClienteTelefono>();
    }
}
