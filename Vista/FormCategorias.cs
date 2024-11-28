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
    public partial class FormCategorias : Form
    {
        ControladoraCategoria controladora;
        public FormCategorias()
        {
            InitializeComponent();
            controladora = new ControladoraCategoria();
            Actualizar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Categoria cat = new Categoria();
                cat.Codigo = txtCodigo.Text;
                cat.Nombre = txtNombre.Text;
                cat.Descripcion = txtDescripcion.Text;

                //MessageBox.Show(cat.NombreProductos());
                if (controladora.CrearCategoria(cat))
                {
                    MessageBox.Show("Agregado.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Error al agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (dgvDatos.Rows.Count > 0)
                {
                    var cat = (Categoria)dgvDatos.CurrentRow.DataBoundItem;
                    cat.Codigo = txtCodigo.Text;
                    cat.Nombre = txtNombre.Text;
                    cat.Descripcion = txtDescripcion.Text;


                    if (controladora.ModificarCategoria(cat))
                    {
                        MessageBox.Show("Modificado.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualizar();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Actualizar()
        {
            //dgvDatos.AutoGenerateColumns = false;
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = controladora.ListarCategorias().AsReadOnly();

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
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo 'Descripcion' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cat = (Categoria)dgvDatos.CurrentRow.DataBoundItem;
            txtNombre.Text = cat.Nombre;
            txtCodigo.Text = cat.Codigo;
            txtDescripcion.Text = cat.Descripcion;
            txtCodigo.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
