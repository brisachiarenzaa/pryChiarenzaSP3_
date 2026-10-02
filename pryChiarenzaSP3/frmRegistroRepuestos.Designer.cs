namespace pryChiarenzaSP3
{
    partial class frmRepuestos
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblNumRepuesto = new System.Windows.Forms.Label();
            this.txtNumRepuesto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.rdbImportado = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lsbDatos = new System.Windows.Forms.ListBox();
            this.gpbOrigen = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(19, 69);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 20);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(17, 113);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(64, 20);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(133, 68);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(107, 24);
            this.cmbMarca.TabIndex = 2;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblNumRepuesto
            // 
            this.lblNumRepuesto.AutoSize = true;
            this.lblNumRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRepuesto.Location = new System.Drawing.Point(17, 215);
            this.lblNumRepuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRepuesto.Name = "lblNumRepuesto";
            this.lblNumRepuesto.Size = new System.Drawing.Size(73, 20);
            this.lblNumRepuesto.TabIndex = 4;
            this.lblNumRepuesto.Text = "Numero:";
            // 
            // txtNumRepuesto
            // 
            this.txtNumRepuesto.Location = new System.Drawing.Point(133, 210);
            this.txtNumRepuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumRepuesto.Name = "txtNumRepuesto";
            this.txtNumRepuesto.Size = new System.Drawing.Size(123, 22);
            this.txtNumRepuesto.TabIndex = 5;
            this.txtNumRepuesto.TextChanged += new System.EventHandler(this.txtNumRepuesto_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(17, 298);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 293);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(173, 22);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(17, 260);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 20);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNacional.Location = new System.Drawing.Point(35, 17);
            this.rdbNacional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(87, 22);
            this.rdbNacional.TabIndex = 9;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            // 
            // rdbImportado
            // 
            this.rdbImportado.AutoSize = true;
            this.rdbImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImportado.Location = new System.Drawing.Point(207, 17);
            this.rdbImportado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbImportado.Name = "rdbImportado";
            this.rdbImportado.Size = new System.Drawing.Size(96, 22);
            this.rdbImportado.TabIndex = 10;
            this.rdbImportado.TabStop = true;
            this.rdbImportado.Text = "Importado";
            this.rdbImportado.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(84, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 24);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "VENTA DE REPUESTOS";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 255);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 22);
            this.txtPrecio.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(21, 370);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 52);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(187, 370);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 52);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lsbDatos
            // 
            this.lsbDatos.FormattingEnabled = true;
            this.lsbDatos.ItemHeight = 16;
            this.lsbDatos.Location = new System.Drawing.Point(13, 549);
            this.lsbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbDatos.Name = "lsbDatos";
            this.lsbDatos.Size = new System.Drawing.Size(346, 116);
            this.lsbDatos.TabIndex = 15;
            // 
            // gpbOrigen
            // 
            this.gpbOrigen.Controls.Add(this.rdbImportado);
            this.gpbOrigen.Controls.Add(this.rdbNacional);
            this.gpbOrigen.Location = new System.Drawing.Point(5, 148);
            this.gpbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbOrigen.Name = "gpbOrigen";
            this.gpbOrigen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbOrigen.Size = new System.Drawing.Size(332, 55);
            this.gpbOrigen.TabIndex = 16;
            this.gpbOrigen.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(102, 465);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(138, 47);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmRepuestos
            // 
            this.AcceptButton = this.btnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(372, 698);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbOrigen);
            this.Controls.Add(this.lsbDatos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNumRepuesto);
            this.Controls.Add(this.lblNumRepuesto);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Repuestos";
            this.Load += new System.EventHandler(this.frmRepuestos_Load);
            this.gpbOrigen.ResumeLayout(false);
            this.gpbOrigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblNumRepuesto;
        private System.Windows.Forms.TextBox txtNumRepuesto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.RadioButton rdbImportado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lsbDatos;
        private System.Windows.Forms.GroupBox gpbOrigen;
        private System.Windows.Forms.Button btnConsultar;
    }
}

