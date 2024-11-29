using Controladora;
using Modelo;

namespace Vista
{
    public partial class FormVenta : Form
    {
        ControladoraFacturas controladora;
        ControladoraDetallesDeFactura controladoraDetalle;
        Factura factura;
        public FormVenta()
        {
            InitializeComponent();
            controladora = new ControladoraFacturas();
            controladoraDetalle = new ControladoraDetallesDeFactura();
            ActualizarCmbClientes();
            ActualizarCmbProducto();
            ActualizarGrillaFacturas();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //if (ValidarCampos())
            //{
            //    factura = new Factura();
            //    factura.Numero = int.Parse(txtNumero.Text);
            //    factura.Fecha = DateTime.Now;
            //    factura.Cliente = controladora.ListarClientes().FirstOrDefault(x => x.Codigo == cmbCliente.Text);
            //    gBoxDetalle.Enabled = true;
            //    btnCerrar.Enabled = true;
            //}

            if (ValidarCampos())
            {
                factura = new Factura
                {
                    Numero = int.Parse(txtNumero.Text),
                    Fecha = DateTime.Now,
                    Cliente = controladora.ListarClientes().FirstOrDefault(x => x.Codigo == cmbCliente.Text)
                };

                // Guarda la factura en la base de datos
                if (controladora.CrearFactura(factura))
                {
                    gBoxDetalle.Enabled = true;
                    btnCerrar.Enabled = true;
                    MessageBox.Show("Factura creada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al crear la factura.");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarCamposDetalle())
            {
                DetalleFactura detalle = new DetalleFactura();
                detalle.Cantidad = int.Parse(txtCantidad.Text);
                detalle.Producto = controladora.ListarProductos().FirstOrDefault(x => x.Nombre == cmbProducto.Text);
                detalle.PrecioUnitario = detalle.Producto.Precio;
                detalle.Factura = factura;
                var detalleCompleto = controladoraDetalle.CrearDetalleFactura(detalle);
                if (detalleCompleto != null)
                {
                    factura.AgregarDetalleFactura(detalleCompleto);
                    ActualizarGrillaDetalles();
                }
                else
                {
                    MessageBox.Show("Fracaso. 😭 ");
                }

            }
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCliente.Text))
            {
                MessageBox.Show("El campo 'Cliente' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCliente.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarCamposDetalle()
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("El campo 'Cantidad' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbProducto.Text))
            {
                MessageBox.Show("El campo 'Producto' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProducto.Focus();
                return false;
            }

            return true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (controladora.CrearFactura(factura))
            {
                ActualizarGrillaFacturas();
                MessageBox.Show("Éxito.");
            }
            else
            {
                MessageBox.Show("Fracaso. 😭 ");
            }
        }

        private void ActualizarGrillaFacturas()
        {
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = controladora.ListarFacturas();
        }

        private void ActualizarGrillaDetalles()
        {
            dgvDetallesFactura.DataSource = null;
            dgvDetallesFactura.DataSource = controladoraDetalle.ListarDetallesFacturas();
        }
        private void ActualizarDetallesFactura(Factura factura)
        {
            //factura = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            dgvDetallesFactura.DataSource = null;
            dgvDetallesFactura.DataSource = controladora.ListarDetallesFactura(factura);
        }
        private void ActualizarCmbClientes()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = controladora.ListarClientes();
        }

        private void ActualizarCmbProducto()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = controladora.ListarProductos();
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            ActualizarDetallesFactura(factura);
        }
    }
}
