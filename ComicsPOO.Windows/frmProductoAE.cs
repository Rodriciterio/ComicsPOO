using ComicsPOO.Entidades;
using ComicsPOO.Windows.Helpers;

namespace ComicsPOO.Windows
{
    public partial class frmProductoAE : Form
    {
        private Producto? producto;

        public frmProductoAE()
        {
            InitializeComponent();
        }

        public Producto? GetProducto()
        {
            return producto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTipoProducto(ref cboTipo);

            if (producto is not null)
            {
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                
            }
        }


        public void SetProducto(Producto? producto)
        {
            this.producto = producto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (producto is null)
                {
                    producto = new Producto();
                }
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                
                


                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "La descripcion del Producto es requerido.");
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio)
                || precio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtPrecio, "Precio mal ingresado o no válido.");
            }
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                valido = false;
                errorProvider1.SetError(txtAutor, "El autor del producto es requerido.");
            }
            if (cboTipo.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTipo, "Debe seleccionar un tipo de producto");
            }
            return valido;
        }

        private void DeshabilitarControles()
        {
            txtAltura.Enabled = false;
            txtAutor.Enabled = false;
            txtDescripcion.Enabled = false;
            cboTipo.Enabled = false;
            gbTipo.Enabled = false;
        }

        private void ManejarControles(TipoProducto tipoProducto)
        {
            if (tipoProducto == TipoProducto.Comic)
            {
                MostrarControles(true);
            }
            else
            {
                MostrarControles(false);
            }

        }

        private void MostrarControles(bool v)
        {
            lblAutor.Visible = v;
            txtAutor.Visible = v;
            lblTipo.Visible = v;
            cboTipo.Visible = v;

            lblAltura.Visible = !v;
            txtAltura.Visible = !v;

        }
    }
}
