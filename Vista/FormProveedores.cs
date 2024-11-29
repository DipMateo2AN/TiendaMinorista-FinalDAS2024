using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormProveedores : Form
    {
        ControladoraProveedores controladora;
        public FormProveedores()
        {
            InitializeComponent();
            controladora = new ControladoraProveedores();
            ActualizarGrilla();
            ActualizarCheckBoxList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Codigo = txtCodigo.Text;
                proveedor.Direccion = txtDireccion.Text;
                proveedor.Contacto = txtContacto.Text;
                proveedor.Nombre = txtNombre.Text;

                foreach (var i in chBoxListProductos.CheckedItems)
                {
                    proveedor.AgregarProducto((Producto)i);
                }

                if (controladora.CrearProveedor(proveedor))
                {
                    MessageBox.Show("Agregado.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void ActualizarGrilla()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = controladora.ListarProveedores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                if (ValidarCampos())
                {
                    var proveedor = (Proveedor)dgvDatos.CurrentRow.DataBoundItem;
                    proveedor.Codigo = txtCodigo.Text;
                    proveedor.Direccion = txtDireccion.Text;
                    proveedor.Contacto = txtContacto.Text;
                    proveedor.Nombre = txtNombre.Text;

                    if (controladora.ModificarProveedor(proveedor))
                    {

                        MessageBox.Show("Modificado.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                var proveedor = (Proveedor)dgvDatos.CurrentRow.DataBoundItem;
                if (controladora.EliminarProveedor(proveedor))
                {
                    MessageBox.Show("Eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarCampos()
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
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Direccion' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtContacto.Text))
            {
                MessageBox.Show("El campo 'Contacto' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContacto.Focus();
                return false;
            }

            return true;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var proveedor = (Proveedor)dgvDatos.CurrentRow.DataBoundItem;
            txtNombre.Text = proveedor.Nombre;
            txtContacto.Text = proveedor.Contacto;
            txtDireccion.Text = proveedor.Direccion;
            txtCodigo.Text = proveedor.Codigo;
            txtCodigo.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarCheckBoxList()
        {
            chBoxListProductos.DataSource = null;
            chBoxListProductos.DataSource = controladora.ListarProductos();
        }
    }
}
