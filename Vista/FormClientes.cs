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
            Cliente cliente = new Cliente();
            cliente.Codigo = txtCodigo.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Contacto = txtContacto.Text;
            cliente.Nombre = txtNombre.Text;

            if(controladora.CrearCliente(cliente))
            {
                MessageBox.Show("Exito");
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Fracasado");
            }
        }

        public virtual void btnModificar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarGrilla()
        {
            dgvDatos.DataSource = null;
            dgvDatos .DataSource = controladora.ListarClientes();
        }
    }
}
