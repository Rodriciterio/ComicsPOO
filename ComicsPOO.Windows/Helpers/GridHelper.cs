using ComicsPOO.Entidades;

namespace ComicsPOO.Windows.Helpers
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

        private static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Producto producto:
                    r.Cells[0].Value = producto.Codigo;
                    r.Cells[1].Value = producto.GetType().Name;
                    r.Cells[2].Value = producto.Descripcion;
                    r.Cells[3].Value = producto.Precio.ToString("C2");
                    r.Cells[4].Value = producto.Stock;
                    break;
                //case Venta venta:
                //    r.Cells[0].Value = venta.NumeroVenta;
                //    r.Cells[1].Value = venta.Fecha.ToShortDateString();
                //    r.Cells[2].Value = venta.Producto!.MostrarInfo();
                //    r.Cells[3].Value = venta.Precio.ToString("C2");
                //    r.Cells[4].Value = venta.Cantidad;
                //    r.Cells[5].Value = venta.Total.ToString("C2");
                //    break;

            }
            r.Tag = obj;
        }

        public static void AgregarFila(DataGridView dgvDatos, DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        internal static void QuitarFila(DataGridViewRow r, DataGridView dgvDatos)
        {
            dgvDatos.Rows.Remove(r);
        }
    }

}
