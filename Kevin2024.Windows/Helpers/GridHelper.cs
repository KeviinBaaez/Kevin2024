using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;

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
        private static void QuitarFila(DataGridViewRow r, DataGridView dgv)
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
