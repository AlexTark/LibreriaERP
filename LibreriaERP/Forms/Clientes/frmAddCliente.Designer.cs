namespace LibreriaERP.Forms.Clientes
{
    partial class frmAddCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtNombreFiscal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bbiGuardar = new System.Windows.Forms.Button();
            this.bbiGuardarYSalir = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bbiGuardarYSalir);
            this.panel1.Controls.Add(this.bbiGuardar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.txtNumCuenta);
            this.panel1.Controls.Add(this.txtMovil);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtNombreFiscal);
            this.panel1.Controls.Add(this.txtNombreComercial);
            this.panel1.Controls.Add(this.txtNif);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 595);
            this.panel1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(45, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 0;
            // 
            // txtNif
            // 
            this.txtNif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NIF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(433, 42);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(282, 26);
            this.txtNif.TabIndex = 1;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NombreComercial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(45, 108);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(323, 26);
            this.txtNombreComercial.TabIndex = 2;
            // 
            // txtNombreFiscal
            // 
            this.txtNombreFiscal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NombreFiscal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombreFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFiscal.Location = new System.Drawing.Point(433, 108);
            this.txtNombreFiscal.Name = "txtNombreFiscal";
            this.txtNombreFiscal.Size = new System.Drawing.Size(331, 26);
            this.txtNombreFiscal.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Direccion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(45, 176);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(719, 26);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(433, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(45, 247);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 26);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtMovil
            // 
            this.txtMovil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Movil", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.Location = new System.Drawing.Point(234, 247);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(152, 26);
            this.txtMovil.TabIndex = 7;
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NumeroCuenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCuenta.Location = new System.Drawing.Point(44, 318);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(720, 26);
            this.txtNumCuenta.TabIndex = 8;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(45, 394);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(719, 146);
            this.txtObservaciones.TabIndex = 9;
            this.txtObservaciones.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre comercial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre fiscal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Móvil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número de cuenta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Observaciones:";
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiGuardar.Location = new System.Drawing.Point(44, 546);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.Size = new System.Drawing.Size(366, 33);
            this.bbiGuardar.TabIndex = 20;
            this.bbiGuardar.Text = "Guardar";
            this.bbiGuardar.UseVisualStyleBackColor = true;
            this.bbiGuardar.Click += new System.EventHandler(this.bbiGuardar_Click);
            // 
            // bbiGuardarYSalir
            // 
            this.bbiGuardarYSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiGuardarYSalir.Location = new System.Drawing.Point(433, 546);
            this.bbiGuardarYSalir.Name = "bbiGuardarYSalir";
            this.bbiGuardarYSalir.Size = new System.Drawing.Size(331, 33);
            this.bbiGuardarYSalir.TabIndex = 21;
            this.bbiGuardarYSalir.Text = "Guardar y salir";
            this.bbiGuardarYSalir.UseVisualStyleBackColor = true;
            this.bbiGuardarYSalir.Click += new System.EventHandler(this.bbiGuardarYSalir_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(LibreriaERP.Clases.Clientes.Cliente);
            // 
            // frmAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 595);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCliente";
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreFiscal;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Button bbiGuardar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button bbiGuardarYSalir;
    }
}