﻿namespace Vista
{
    partial class FormClientes
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
            dgvDatos = new DataGridView();
            gBoxCliente = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            txtContacto = new TextBox();
            label3 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            gBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(280, 21);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(454, 218);
            dgvDatos.TabIndex = 3;
            // 
            // gBoxCliente
            // 
            gBoxCliente.Controls.Add(btnEliminar);
            gBoxCliente.Controls.Add(btnModificar);
            gBoxCliente.Controls.Add(btnAgregar);
            gBoxCliente.Controls.Add(label4);
            gBoxCliente.Controls.Add(txtContacto);
            gBoxCliente.Controls.Add(label3);
            gBoxCliente.Controls.Add(txtDireccion);
            gBoxCliente.Controls.Add(label2);
            gBoxCliente.Controls.Add(txtNombre);
            gBoxCliente.Controls.Add(label1);
            gBoxCliente.Controls.Add(txtCodigo);
            gBoxCliente.Location = new Point(31, 21);
            gBoxCliente.Name = "gBoxCliente";
            gBoxCliente.Size = new Size(217, 250);
            gBoxCliente.TabIndex = 2;
            gBoxCliente.TabStop = false;
            gBoxCliente.Text = "Datos:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(37, 211);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(37, 185);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(149, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 156);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 129);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Contacto:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(98, 121);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(98, 92);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 71);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(98, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(585, 248);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 288);
            Controls.Add(btnSalir);
            Controls.Add(dgvDatos);
            Controls.Add(gBoxCliente);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            gBoxCliente.ResumeLayout(false);
            gBoxCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected DataGridView dgvDatos;
        protected GroupBox gBoxCliente;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtContacto;
        private Label label3;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCodigo;
        protected Button btnSalir;
    }
}