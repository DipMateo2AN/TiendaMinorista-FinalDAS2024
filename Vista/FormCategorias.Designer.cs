namespace Vista
{
    partial class FormCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            dgvDatos = new DataGridView();
            gBoxCliente = new GroupBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            gBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 343);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(170, 31);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(320, 40);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(519, 291);
            dgvDatos.TabIndex = 13;
            dgvDatos.CellClick += dgvDatos_CellClick;
            // 
            // gBoxCliente
            // 
            gBoxCliente.Controls.Add(btnModificar);
            gBoxCliente.Controls.Add(btnAgregar);
            gBoxCliente.Controls.Add(label3);
            gBoxCliente.Controls.Add(txtDescripcion);
            gBoxCliente.Controls.Add(label2);
            gBoxCliente.Controls.Add(txtNombre);
            gBoxCliente.Controls.Add(label1);
            gBoxCliente.Controls.Add(txtCodigo);
            gBoxCliente.Location = new Point(35, 40);
            gBoxCliente.Margin = new Padding(3, 4, 3, 4);
            gBoxCliente.Name = "gBoxCliente";
            gBoxCliente.Padding = new Padding(3, 4, 3, 4);
            gBoxCliente.Size = new Size(248, 303);
            gBoxCliente.TabIndex = 12;
            gBoxCliente.TabStop = false;
            gBoxCliente.Text = "Datos:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(41, 232);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 31);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 193);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(170, 31);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 133);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 123);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(114, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 95);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 84);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(112, 45);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 0;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 391);
            Controls.Add(btnSalir);
            Controls.Add(dgvDatos);
            Controls.Add(gBoxCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCategorias";
            Text = "FormCategorias";
            Load += FormCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            gBoxCliente.ResumeLayout(false);
            gBoxCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Button btnSalir;
        protected DataGridView dgvDatos;
        protected GroupBox gBoxCliente;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtContacto;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCodigo;
    }
}