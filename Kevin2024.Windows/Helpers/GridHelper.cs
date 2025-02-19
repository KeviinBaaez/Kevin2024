using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Entidades.ViewModels;

namespace Kevin2024.Windows.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }
        public static void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }
        public static int ObtenerRowIndex(DataGridView dgv, int id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = dgv.Rows[i];
                if ((int)row.Cells[0].Value == id)
                {
                    return i;
                }
            }
            return -1;

        }
        public static void MarcarRow(DataGridView dgvDatos, int rowIndex)
        {
            if (rowIndex >= 0)
            {
                dgvDatos.Rows[rowIndex].Selected = true;
                dgvDatos.FirstDisplayedScrollingRowIndex = rowIndex;
            }

        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case ProductosListDto p:
                    r.Cells[0].Value = p.ProductoId;
                    r.Cells[1].Value = p.Nombre;
                    r.Cells[2].Value = p.Marca;
                    r.Cells[3].Value = p.CodBarras;
                    r.Cells[4].Value = p.Tamanio;
                    r.Cells[5].Value = p.Categoria;
                    r.Cells[6].Value = p.PrecioVenta;
                    r.Cells[7].Value = p.Stock;
                    r.Cells[8].Value = p.Suspendido;
                    break;
                case EmpleadosListDto e:
                    r.Cells[0].Value = e.EmpleadoId;
                    r.Cells[1].Value = e.Nombre;
                    r.Cells[2].Value = e.Dni;
                    r.Cells[3].Value = e.Salario;
                    r.Cells[4].Value = e.Suspendido;
                    break;
                case TiposDeDatos tiposDeDatos:
                    r.Cells[0].Value = tiposDeDatos.TipoId;
                    r.Cells[1].Value = tiposDeDatos.Descripcion;
                    break;
                case DetallesCombos dt:
                    r.Cells[0].Value = dt.ProductoId;
                    r.Cells[1].Value = dt.Producto!.Nombre;
                    r.Cells[2].Value = dt.Cantidad;
                    r.Cells[3].Value = dt.Producto.Tamanio;
                    break;
                case ComboListDto comboListDto:
                    r.Cells[0].Value = comboListDto.ComboId;
                    r.Cells[1].Value = comboListDto.Nombre;
                    r.Cells[2].Value = comboListDto.Tamanio;
                    r.Cells[3].Value = comboListDto.PrecioVenta;
                    r.Cells[4].Value = comboListDto.Stock;
                    r.Cells[5].Value = comboListDto.Suspendido;
                    break;
                case DetalleVenta dtVenta:
                    r.Cells[0].Value = dtVenta.VentaId;
                    r.Cells[1].Value = dtVenta.Productos?.Nombre;
                    r.Cells[2].Value = dtVenta.Cantidad;
                    r.Cells[3].Value = dtVenta.Precio;
                    r.Cells[4].Value = dtVenta.Cantidad * dtVenta.Precio;
                    break;
                case DetalleOrden dtOrden:
                    r.Cells[0].Value = dtOrden.OrdenId;
                    r.Cells[1].Value = dtOrden.Productos?.Nombre;
                    r.Cells[2].Value = dtOrden.Cantidad;
                    r.Cells[3].Value = dtOrden.Precio;
                    r.Cells[4].Value = dtOrden.Cantidad * dtOrden.Precio;
                    break;
                case ClienteListDto clienteDto:
                    r.Cells[0].Value = clienteDto.ClienteId;
                    r.Cells[1].Value = clienteDto.NombreCompleto;
                    r.Cells[2].Value = clienteDto.Documento;
                    r.Cells[3].Value = clienteDto.DireccionPrincipal;
                    r.Cells[4].Value = clienteDto.TelefonoPrincipal;
                    break;
                case DireccionConTipoVm direccionConTipoVm:
                    r.Cells[0].Value = direccionConTipoVm.Direccion!.DireccionId;
                    r.Cells[1].Value = direccionConTipoVm.ToString();
                    break;
                case TelefonoConTipoVm telefonoConTipoVm:
                    r.Cells[0].Value = telefonoConTipoVm.Telefono.TelefonoId;
                    r.Cells[1].Value = telefonoConTipoVm.ToString();
                    break;
                case Direccion clienteDireccion:
                    r.Cells[0].Value = clienteDireccion.DireccionId;
                    r.Cells[1].Value = clienteDireccion.ToString();
                    break;
                case Telefonos clienteTelefono:
                    r.Cells[0].Value = clienteTelefono.TelefonoId;
                    r.Cells[1].Value = clienteTelefono.ToString();
                    break;
                case VentaListDto ventaDto:
                    r.Cells[0].Value = ventaDto.VentaId;
                    if (ventaDto.TipoOrdenId == 1)
                    {
                        r.Cells[1].Value = "Local";
                    }
                    else if (ventaDto.TipoOrdenId == 2)
                    {
                        r.Cells[1].Value = "Take Away";
                    }
                    else
                    {
                        r.Cells[1].Value = "Delivery";
                    }
                    r.Cells[2].Value = ventaDto.Cliente;
                    r.Cells[3].Value = ventaDto.FechaVenta.ToShortDateString();
                    r.Cells[4].Value = ventaDto.Regalo;
                    r.Cells[5].Value = ventaDto.Total;
                    break;
                case OrdenListDto ordenDto:
                    r.Cells[0].Value = ordenDto.OrdenId;
                    if (ordenDto.TipoOrdenId == 1)
                    {
                        r.Cells[1].Value = "Local";
                    }
                    else if (ordenDto.TipoOrdenId == 2)
                    {
                        r.Cells[1].Value = "Take Away";
                    }
                    else
                    {
                        r.Cells[1].Value = "Delivery";
                    }
                    r.Cells[2].Value = ordenDto.Cliente;
                    r.Cells[3].Value = ordenDto.FechaOrden.ToShortDateString();
                    r.Cells[4].Value = ordenDto.Regalo;
                    r.Cells[5].Value = ordenDto.Total;
                    r.Cells[6].Value = ordenDto.EstadoOrden;
                    r.Cells[7].Value = ordenDto.EstadoPago;
                    
                    break;
                case Usuario usuario:
                    r.Cells[0].Value = usuario.UsuarioId;
                    r.Cells[1].Value = usuario.NombreUsuario;
                    r.Cells[2].Value = usuario.Clave;
                    r.Cells[3].Value = usuario.Rol;
                    r.Cells[4].Value = usuario.Activo;
                    break;
            }
            r.Tag = obj;
        }

        private static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;
        }

        private static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
    }
}
