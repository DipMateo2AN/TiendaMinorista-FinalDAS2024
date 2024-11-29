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
                ActualizarGrillaFacturas();
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
                    ActualizarGrillaDetalles(factura);
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

        private void ActualizarGrillaFacturas()
        {
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = controladora.ListarFacturas();
        }

        private void ActualizarGrillaDetalles(Factura factura)
        {
            var fSeleccionada = controladora.ListarFacturas().FirstOrDefault(f => f.Numero == factura.Numero);
            dgvDetallesFactura.DataSource = null;
            dgvDetallesFactura.DataSource = fSeleccionada.ListarDetallesFacturas().AsReadOnly();
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

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            var facturaSeleccionada = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            ActualizarGrillaDetalles(facturaSeleccionada);
        }

        private void ActualizarDetallesFactura(Factura factura)
        {
            dgvDetallesFactura.DataSource = null;
            dgvDetallesFactura.DataSource = controladora.ListarDetallesFactura(factura);
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            ActualizarDetallesFactura(factura);
        }
    }
}
