using ComicsPOO.Datos;
using ComicsPOO.Entidades;
using ComicsPOO.Windows.Helpers;
using System.Drawing.Printing;

namespace ComicsPOO.Windows
{
    public partial class frmComics : Form
    {
        private Comiqueria? comiqueria;


        public frmComics()
        {
            InitializeComponent();
            comiqueria = new Comiqueria();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            comiqueria!.GuardarDatos();
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmProductoAE frm = new frmProductoAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Producto? producto = frm.GetProducto();
            if (producto == null) return;
            comiqueria!.AgregarProducto(producto);
            GridHelper.MostrarDatosEnGrilla<Producto>(comiqueria.GetProductos(), dgvDatos);
            MessageBox.Show($"Se agrego {producto.ToString()}", "Agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvDatos.SelectedRows[0];
            if (selectedRow.Tag is null)
            {
                MessageBox.Show("El producto seleccionado no es válido.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productoB = (Producto)selectedRow.Tag;
            DialogResult dialogResult = MessageBox.Show($"¿Desea dar de baja el producto {productoB.Codigo}?",
                                                         "Confirmar",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question,
                                                         MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.No) return;

            try
            {
                if (comiqueria!.ExisteProducto(productoB.Descripcion))
                {
                    comiqueria.QuitarProducto(productoB.Codigo);
                    GridHelper.MostrarDatosEnGrilla<Producto>(comiqueria.GetProductos(),dgvDatos);

                    MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el registro.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;

            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Producto producto = (Producto)filaSeleccionada.Tag;
            frmProductoAE frm = new frmProductoAE() { Text = "Editar Producto" };
            frm.SetProducto(producto);
            var descripcion = producto!.Descripcion;
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            producto = frm.GetProducto();

            if (producto == null) return;

            try
            {
                if (!comiqueria!.ExisteProducto(descripcion))
                {
                    //comiqueria.GuardarDatos
                    comiqueria.AgregarProducto(producto);

                    GridHelper.MostrarDatosEnGrilla<Producto>(comiqueria.GetProductos(), dgvDatos);

                    MessageBox.Show("Registro editado",
                       "Mensaje",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro existente\nEdición denegada",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void frmComics_Load(object sender, EventArgs e)
        {
            GridHelper.MostrarDatosEnGrilla<Producto>(comiqueria.GetProductos(), dgvDatos);
        }
    }
}
