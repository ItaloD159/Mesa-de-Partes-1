namespace Mesa_de_Partes_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPersona = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.CBTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersona
            // 
            this.grpPersona.Controls.Add(this.label1);
            this.grpPersona.Controls.Add(this.CBTipoDocumento);
            this.grpPersona.Controls.Add(this.btnBuscar);
            this.grpPersona.Controls.Add(this.btnLimpiar);
            this.grpPersona.Controls.Add(this.btnRegistrar);
            this.grpPersona.Controls.Add(this.txtAsunto);
            this.grpPersona.Controls.Add(this.txtTelefono);
            this.grpPersona.Controls.Add(this.txtApellidos);
            this.grpPersona.Controls.Add(this.txtNombres);
            this.grpPersona.Controls.Add(this.txtNumeroDocumento);
            this.grpPersona.Controls.Add(this.lblAsunto);
            this.grpPersona.Controls.Add(this.lblTelefono);
            this.grpPersona.Controls.Add(this.lblApellidos);
            this.grpPersona.Controls.Add(this.lblNombres);
            this.grpPersona.Controls.Add(this.lblDni);
            this.grpPersona.Location = new System.Drawing.Point(0, 0);
            this.grpPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPersona.Name = "grpPersona";
            this.grpPersona.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPersona.Size = new System.Drawing.Size(326, 396);
            this.grpPersona.TabIndex = 0;
            this.grpPersona.TabStop = false;
            this.grpPersona.Text = "Datos de la persona";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 351);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 25);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar por DNI";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 308);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 25);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(24, 266);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 27);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(152, 221);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(147, 20);
            this.txtAsunto.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(152, 192);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(152, 161);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(147, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(152, 130);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(147, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(152, 100);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(147, 20);
            this.txtNumeroDocumento.TabIndex = 6;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(27, 224);
            this.lblAsunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(50, 13);
            this.lblAsunto.TabIndex = 5;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(27, 195);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(27, 164);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(62, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(27, 133);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(60, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(27, 103);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(109, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "N° de documento:";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTitulo.Location = new System.Drawing.Point(521, 8);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA DE MESA DE PARTES";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(356, 23);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.RowTemplate.Height = 24;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(483, 362);
            this.dgvPersonas.TabIndex = 1;
            // 
            // CBTipoDocumento
            // 
            this.CBTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDocumento.FormattingEnabled = true;
            this.CBTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CE"});
            this.CBTipoDocumento.Location = new System.Drawing.Point(152, 66);
            this.CBTipoDocumento.Name = "CBTipoDocumento";
            this.CBTipoDocumento.Size = new System.Drawing.Size(147, 21);
            this.CBTipoDocumento.TabIndex = 14;
            this.CBTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de documento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 396);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.grpPersona);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MESA DE PARTES";
            this.grpPersona.ResumeLayout(false);
            this.grpPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersona;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTipoDocumento;
    }
}

