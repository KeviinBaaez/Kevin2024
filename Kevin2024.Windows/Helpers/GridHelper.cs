using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entindades;

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
                case Marcas m:
                    r.Cells[0].Value = m.MarcaId;
                    r.Cells[1].Value = m.Nombre;
                    break;
                case Categorias c:
                    r.Cells[0].Value = c.CategoriaId;
                    r.Cells[1].Value = c.Descripcion;
                    break;
                case Ingredientes ing:
                    r.Cells[0].Value = ing.IngredienteId;
                    r.Cells[1].Value = ing.Nombre;
                    r.Cells[2].Value = ing.Suspendido;
                    break;
                case ProductosListDto p:
                    r.Cells[0].Value = p.ProductoId;
                    r.Cells[1].Value = p.Nombre;
                   // r.Cells[2].Value = p.Marca;
                    r.Cells[3].Value = p.Sabor;
                    r.Cells[4].Value = p.CodBarras;
                   // r.Cells[5].Value = p.Tamanio;
                   // r.Cells[6].Value = p.Categoria;
                    r.Cells[7].Value = p.PrecioCosto;
                    r.Cells[8].Value = p.PrecioVenta;
                    r.Cells[9].Value = p.Stock;
                    r.Cells[10].Value = p.NivelDeReposicion;
                    r.Cells[11].Value = p.Suspendido;
                    break;
                case Tamanio t:
                    r.Cells[0].Value = t.TamanioId;
                    r.Cells[1].Value = t.Descripcion;
                    r.Cells[2].Value = t.Cantidad;
                    break;
                //case PostresListDto p:
                //    r.Cells[0].Value = p.ProductoId;
                //    r.Cells[1].Value = p.Nombre;
                //    r.Cells[2].Value = p.marca;
                //    r.Cells[3].Value = p.Sabor;
                //    r.Cells[4].Value = p.CodigoBarras;
                //    r.Cells[5].Value = p.Tamanio;
                //    r.Cells[6].Value = p.PrecioCosto;
                //    r.Cells[7].Value = p.Precio;
                //    r.Cells[8].Value = p.Stock;
                //    r.Cells[9].Value = p.NivelDeReposicion;
                //    r.Cells[10].Value = p.Suspendido;
                //    break;

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
