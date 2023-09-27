namespace Proyecto5
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gB_Genero = new System.Windows.Forms.GroupBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gB_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(100, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(160, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(100, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(160, 97);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(100, 20);
            this.txtEstatura.TabIndex = 5;
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(100, 100);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(46, 13);
            this.lblEstatura.TabIndex = 4;
            this.lblEstatura.Text = "Estatura";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 136);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(95, 139);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(160, 174);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(112, 177);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // gB_Genero
            // 
            this.gB_Genero.Controls.Add(this.rbMujer);
            this.gB_Genero.Controls.Add(this.rbHombre);
            this.gB_Genero.Location = new System.Drawing.Point(73, 225);
            this.gB_Genero.Name = "gB_Genero";
            this.gB_Genero.Size = new System.Drawing.Size(200, 67);
            this.gB_Genero.TabIndex = 10;
            this.gB_Genero.TabStop = false;
            this.gB_Genero.Text = "groupBox1";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(115, 32);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 1;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(6, 32);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 0;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 298);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 57);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(92, 361);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 57);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gB_Genero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gB_Genero.ResumeLayout(false);
            this.gB_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox gB_Genero;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

