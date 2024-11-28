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
using Controladora;
using System.ComponentModel.DataAnnotations;

namespace Vista
{
    public partial class FormClientes : Form
    {
        ControladoraClientes controladora;
        public FormClientes()
        {
            InitializeComponent();
            controladora = new ControladoraClientes();
            ActualizarGrilla();
        }

        public virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cliente cliente = new Cliente();
                cliente.Codigo = txtCodigo.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Contacto = txtContacto.Text;
                cliente.Nombre = txtNombre.Text;

                if (controladora.CrearCliente(cliente))
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

        public virtual void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                if (ValidarCampos())
                {
                    var cliente = (Cliente)dgvDatos.CurrentRow.DataBoundItem;
                    cliente.Codigo = txtCodigo.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Contacto = txtContacto.Text;
                    cliente.Nombre = txtNombre.Text;

                    if (controladora.ModificarCliente(cliente))
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

        public virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                var cliente = (Cliente)dgvDatos.CurrentRow.DataBoundItem;
                if (controladora.EliminarCliente(cliente))
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

        public virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarGrilla()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = controladora.ListarClientes();
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
            var cliente = (Cliente)dgvDatos.CurrentRow.DataBoundItem;
            txtNombre.Text = cliente.Nombre;
            txtContacto.Text = cliente.Contacto;
            txtDireccion.Text = cliente.Direccion;
            txtCodigo.Text = cliente.Codigo;
            txtCodigo.Enabled = false;
        }
    }
}
