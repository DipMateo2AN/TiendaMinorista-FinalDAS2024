using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class FormProductos : Form
    {
        ControladoraProductos controladora;
        //ControladoraCategoria controladoraCategoria = ControladoraCategoria.Instancia;
        public FormProductos()
        {
            InitializeComponent();
            controladora = new ControladoraProductos();
            CargarCategorias();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Nacional")
            {
                dateTime.Enabled = false;
                txtPais.Enabled = false;
            }
            else
            {
                dateTime.Enabled = true;
                txtPais.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Nacional":
                    if (ValidarCamposNacional())
                    {
                        Producto producto = new Producto();
                        producto.Codigo = txtCodigo.Text;
                        producto.Nombre = txtNombre.Text;
                        producto.Descripcion = txtDescripcion.Text;
                        producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                        producto.Stock = Convert.ToInt32(txtStock.Text);
                        producto.Categoria = (Categoria)cmbCategorias.SelectedItem;

                        if (controladora.CrearProducto(producto, (Categoria)cmbCategorias.SelectedItem))
                        {
                            MessageBox.Show("Producto agregado correctamente.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Importado":

                    if (ValidarCamposImportado())
                    {
                        ProductoImportado producto = new ProductoImportado();
                        producto.Codigo = txtCodigo.Text;
                        producto.Nombre = txtNombre.Text;
                        producto.Descripcion = txtDescripcion.Text;
                        producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                        producto.Stock = Convert.ToInt32(txtStock.Text);
                        producto.PaisImportacion = txtPais.Text;
                        producto.FechaImportacion = dateTime.Value;
                        producto.Categoria = (Categoria)cmbCategorias.SelectedItem;

                        if (controladora.CrearProducto(producto, (Categoria)cmbCategorias.SelectedItem))
                        {
                            MessageBox.Show("Producto agregado correctamente.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
                default:
                    MessageBox.Show("Debes seleccionar un tipo de producto!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Nacional":
                    if (dgvProductos.Rows.Count > 0)
                    {
                        if (ValidarCamposNacional())
                        {
                            var producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                            producto.Codigo = txtCodigo.Text;
                            producto.Nombre = txtNombre.Text;
                            producto.Descripcion = txtDescripcion.Text;
                            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                            producto.Stock = Convert.ToInt32(txtStock.Text);
                            producto.Categoria = (Categoria)cmbCategorias.SelectedItem;

                            if (controladora.ModificarProducto(producto, (Categoria)cmbCategorias.SelectedItem))
                            {
                                MessageBox.Show("Producto modificado correctamente.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Actualizar();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                case "Importado":
                    if (dgvProductosImportados.Rows.Count > 0)
                    {
                        if (ValidarCamposImportado())
                        {
                            var producto = (ProductoImportado)dgvProductosImportados.CurrentRow.DataBoundItem;
                            producto.Codigo = txtCodigo.Text;
                            producto.Nombre = txtNombre.Text;
                            producto.Descripcion = txtDescripcion.Text;
                            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                            producto.Stock = Convert.ToInt32(txtStock.Text);
                            producto.PaisImportacion = txtPais.Text;
                            producto.FechaImportacion = dateTime.Value;
                            producto.Categoria = (Categoria)cmbCategorias.SelectedItem;

                            if (controladora.ModificarProducto(producto, (Categoria)cmbCategorias.SelectedItem))
                            {
                                MessageBox.Show("Producto modificado correctamente.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Actualizar();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Debes seleccionar un tipo de producto!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Nacional":
                    if (dgvProductos.Rows.Count > 0)                      
                    {
                        var producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

                        if (controladora.EliminarProducto(producto))
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Importado":
                    if (dgvProductosImportados.Rows.Count > 0)
                    {
                        var producto = (ProductoImportado)dgvProductosImportados.CurrentRow.DataBoundItem;

                        if (controladora.EliminarProducto(producto))
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Debes seleccionar un tipo de producto!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void Actualizar()
        {
            dgvProductos.DataSource = null;
            dgvProductosImportados.DataSource = null;
            dgvProductos.DataSource = controladora.ListarProductos();
            dgvProductosImportados.DataSource = controladora.ListarProductosImportados();
        }

        public void CargarCategorias()
        {
            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = controladora.ListarCategorias();
            cmbCategorias.DisplayMember = "Nombre";
        }

        private bool ValidarCamposImportado()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El campo 'Codigo' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo 'Descripcion' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El campo 'Precio' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("El campo 'Stock' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("El campo 'Pais de importacion' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarCamposNacional()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El campo 'Codigo' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo 'Descripcion' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El campo 'Precio' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("El campo 'Stock' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
