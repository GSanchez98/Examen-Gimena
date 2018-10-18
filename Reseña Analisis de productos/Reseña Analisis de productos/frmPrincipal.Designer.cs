namespace Reseña_Analisis_de_productos
{
    partial class frmPrincipal
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
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lbComentarios = new System.Windows.Forms.Label();
            this.lbValoracion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbListadoProductos = new System.Windows.Forms.ListBox();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.txtValoracion);
            this.gbPrincipal.Controls.Add(this.btnSalir);
            this.gbPrincipal.Controls.Add(this.btnAceptar);
            this.gbPrincipal.Controls.Add(this.txtComentarios);
            this.gbPrincipal.Controls.Add(this.lbComentarios);
            this.gbPrincipal.Controls.Add(this.lbValoracion);
            this.gbPrincipal.Controls.Add(this.txtCorreo);
            this.gbPrincipal.Controls.Add(this.lbCorreo);
            this.gbPrincipal.Controls.Add(this.txtNombre);
            this.gbPrincipal.Controls.Add(this.lbNombre);
            this.gbPrincipal.Controls.Add(this.lbListadoProductos);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 16);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(608, 291);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Seleccione el producto a realizar su reseña";
            this.gbPrincipal.Enter += new System.EventHandler(this.gbPrincipal_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(307, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(157, 262);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(321, 148);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarios.Size = new System.Drawing.Size(239, 96);
            this.txtComentarios.TabIndex = 8;
            // 
            // lbComentarios
            // 
            this.lbComentarios.AutoSize = true;
            this.lbComentarios.Location = new System.Drawing.Point(224, 151);
            this.lbComentarios.Name = "lbComentarios";
            this.lbComentarios.Size = new System.Drawing.Size(65, 13);
            this.lbComentarios.TabIndex = 7;
            this.lbComentarios.Text = "Comentarios";
            // 
            // lbValoracion
            // 
            this.lbValoracion.AutoSize = true;
            this.lbValoracion.Location = new System.Drawing.Point(224, 109);
            this.lbValoracion.Name = "lbValoracion";
            this.lbValoracion.Size = new System.Drawing.Size(57, 13);
            this.lbValoracion.TabIndex = 5;
            this.lbValoracion.Text = "Valoracion";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(321, 66);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(239, 20);
            this.txtCorreo.TabIndex = 4;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(224, 69);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(94, 13);
            this.lbCorreo.TabIndex = 3;
            this.lbCorreo.Text = "Correo Electronico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(321, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(224, 32);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(91, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre Completo";
            // 
            // lbListadoProductos
            // 
            this.lbListadoProductos.FormattingEnabled = true;
            this.lbListadoProductos.Items.AddRange(new object[] {
            "   [LISTADO DE PRODUCTOS]"});
            this.lbListadoProductos.Location = new System.Drawing.Point(20, 32);
            this.lbListadoProductos.Name = "lbListadoProductos";
            this.lbListadoProductos.Size = new System.Drawing.Size(177, 212);
            this.lbListadoProductos.TabIndex = 0;
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(321, 106);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(239, 20);
            this.txtValoracion.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 319);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Reseñ/Analisis de productos-AdventureWorks";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lbComentarios;
        private System.Windows.Forms.Label lbValoracion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ListBox lbListadoProductos;
        private System.Windows.Forms.TextBox txtValoracion;
    }
}

