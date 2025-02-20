﻿namespace Kevin2024.Entidades.Entidades
{
    public class Empleados
    {
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public DateTime FechaContrato { get; set; }
        public double Salario { get; set; }
        public bool Suspendido { get; set; }
        public int GeneroId {  get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Imagen {  get; set; }

    }
}
