using Controladora;
using Modelo;

namespace Vista
{
    public partial class FormVenta : Form
    {
        ControladoraFacturas controladora;
        Factura factura;
        DetalleFactura detalleFacturaSeleccionada;
        public FormVenta()
        {
            InitializeComponent();
            controladora = new ControladoraFacturas();
            ActualizarCmbClientes();
            ActualizarCmbProducto();
            ActualizarGrillaFacturas();
        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Factura creada correctamente.");
                    ActualizarGrillaFacturas(); // Actualiza la lista de facturas
                }
                else
                {
                    MessageBox.Show("Error al crear la factura.");
                }
            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (ValidarCamposDetalle())
            {
                var producto = controladora.ListarProductos().FirstOrDefault(x => x.Nombre == cmbProducto.Text);
                if (producto == null)
                {
                    MessageBox.Show("El producto seleccionado no es vÃ¡lido.");
                    return;
                }

                DetalleFactura detalle = new DetalleFactura
                {
                    Cantidad = int.Parse(txtCantidad.Text),
                    Producto = producto,
                    PrecioUnitario = producto.Precio,
                    Factura = factura
                };

                //var detalleCompleto = controladoraDetalle.CrearDetalleFactura(detalle);
                //if (detalleCompleto != null)
                //{
                //    MessageBox.Show("Detalle agregado correctamente.");
                //    //ActualizarGrillaDetalles(factura); // Asegura que los detalles se actualicen correctamente
                //    //ActualizarGrillaFacturas();
                //}
                //else
                //{
                //    MessageBox.Show("Error al agregar el detalle.");
                //}
            }
            ActualizarGrillaDetalles(factura); // Asegura que los detalles se actualicen correctamente
            ActualizarGrillaFacturas();
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
            if (factura == null)
            {
                dgvDetallesFactura.DataSource = null;
                return;
            }

            //var detalles = controladoraDetalle.ListarDetallesFactura(factura);
            //dgvDetallesFactura.DataSource = null;
            //dgvDetallesFactura.DataSource = detalles;
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
            //factura = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            //ActualizarDetallesFactura(factura);
            gBoxDetalle.Enabled = true;


            if (dgvFacturas.CurrentRow?.DataBoundItem is Factura facturaSeleccionada)
            {
                factura = facturaSeleccionada;
                ActualizarGrillaDetalles(factura);
                txtNumero.Text = factura.Numero.ToString();
            }

        }

        private void dgvDetallesFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //detalleFacturaSeleccionada = controladoraDetalle.ListarTodosLosDetalles().FirstOrDefault(x => x.Id == int.Parse(dgvDetallesFactura.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        //    controladoraDetalle.EliminarDetalle(detalleFacturaSeleccionada);
        //    ActualizarGrillaFacturas();
        }


    }
}