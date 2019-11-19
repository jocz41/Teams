namespace Practica_8
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabEquipo = new System.Windows.Forms.TabPage();
            this.tabTitular = new System.Windows.Forms.TabPage();
            this.tabFinal = new System.Windows.Forms.TabPage();
            this.txtCodigo = new Practica_8.CajaTextoHexa();
            this.lblCodigo = new Practica_8.Verdana12Negro();
            this.txtNombreEq = new Practica_8.CajaTextoMay();
            this.lblNombre = new Practica_8.Verdana12Negro();
            this.lblColor = new Practica_8.Verdana12Negro();
            this.txtColor = new Practica_8.CajaTextoMin();
            this.calAnioNac = new Practica_8.Calendario();
            this.lblNacimiento = new Practica_8.Verdana12Negro();
            this.cajaTextoMayInic2 = new Practica_8.CajaTextoMayInic();
            this.lblNomTitular = new Practica_8.Verdana12Negro();
            this.lblLocalidad = new Practica_8.Verdana12Negro();
            this.txtLocalidad = new Practica_8.CajaTextoMayInic();
            this.btnBorrar = new Practica_8.BotonVerdana();
            this.btnInscribirse = new Practica_8.BotonVerdana();
            this.lblTitulo = new Practica_8.Verdana12Negro();
            this.txtTlf = new Practica_8.CajaTextoNum();
            this.lblTlf = new Practica_8.Verdana12Negro();
            this.txtEmail = new Practica_8.CajaTextoEmail();
            this.lblEmail = new Practica_8.Verdana12Negro();
            this.tabPanel.SuspendLayout();
            this.tabEquipo.SuspendLayout();
            this.tabTitular.SuspendLayout();
            this.tabFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabEquipo);
            this.tabPanel.Controls.Add(this.tabTitular);
            this.tabPanel.Controls.Add(this.tabFinal);
            this.tabPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPanel.Location = new System.Drawing.Point(58, 132);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(1085, 262);
            this.tabPanel.TabIndex = 7;
            this.tabPanel.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.cambiaPestania);
            // 
            // tabEquipo
            // 
            this.tabEquipo.BackColor = System.Drawing.Color.Gray;
            this.tabEquipo.Controls.Add(this.txtCodigo);
            this.tabEquipo.Controls.Add(this.lblCodigo);
            this.tabEquipo.Controls.Add(this.txtNombreEq);
            this.tabEquipo.Controls.Add(this.lblNombre);
            this.tabEquipo.Controls.Add(this.lblColor);
            this.tabEquipo.Controls.Add(this.txtColor);
            this.tabEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.tabEquipo.Location = new System.Drawing.Point(4, 34);
            this.tabEquipo.Name = "tabEquipo";
            this.tabEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquipo.Size = new System.Drawing.Size(1077, 224);
            this.tabEquipo.TabIndex = 0;
            this.tabEquipo.Text = "Equipo";
            // 
            // tabTitular
            // 
            this.tabTitular.BackColor = System.Drawing.Color.Gray;
            this.tabTitular.Controls.Add(this.txtEmail);
            this.tabTitular.Controls.Add(this.lblEmail);
            this.tabTitular.Controls.Add(this.txtTlf);
            this.tabTitular.Controls.Add(this.lblTlf);
            this.tabTitular.Controls.Add(this.calAnioNac);
            this.tabTitular.Controls.Add(this.lblNacimiento);
            this.tabTitular.Controls.Add(this.cajaTextoMayInic2);
            this.tabTitular.Controls.Add(this.lblNomTitular);
            this.tabTitular.Controls.Add(this.lblLocalidad);
            this.tabTitular.Controls.Add(this.txtLocalidad);
            this.tabTitular.ForeColor = System.Drawing.SystemColors.Control;
            this.tabTitular.Location = new System.Drawing.Point(4, 34);
            this.tabTitular.Name = "tabTitular";
            this.tabTitular.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitular.Size = new System.Drawing.Size(1077, 224);
            this.tabTitular.TabIndex = 1;
            this.tabTitular.Text = "Titular";
            // 
            // tabFinal
            // 
            this.tabFinal.BackColor = System.Drawing.Color.Gray;
            this.tabFinal.Controls.Add(this.btnBorrar);
            this.tabFinal.Controls.Add(this.btnInscribirse);
            this.tabFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.tabFinal.Location = new System.Drawing.Point(4, 34);
            this.tabFinal.Name = "tabFinal";
            this.tabFinal.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinal.Size = new System.Drawing.Size(1077, 224);
            this.tabFinal.TabIndex = 2;
            this.tabFinal.Text = "Finalizar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(730, 125);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(302, 32);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(610, 132);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 20);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código:";
            // 
            // txtNombreEq
            // 
            this.txtNombreEq.Location = new System.Drawing.Point(242, 59);
            this.txtNombreEq.Name = "txtNombreEq";
            this.txtNombreEq.Size = new System.Drawing.Size(790, 32);
            this.txtNombreEq.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre (MAY):";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(38, 132);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(126, 20);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color (min):";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(242, 125);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(314, 32);
            this.txtColor.TabIndex = 2;
            // 
            // calAnioNac
            // 
            this.calAnioNac.CustomFormat = "yyyy";
            this.calAnioNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calAnioNac.Location = new System.Drawing.Point(905, 141);
            this.calAnioNac.MaxDate = new System.DateTime(2000, 1, 8, 0, 0, 0, 0);
            this.calAnioNac.Name = "calAnioNac";
            this.calAnioNac.ShowUpDown = true;
            this.calAnioNac.Size = new System.Drawing.Size(114, 32);
            this.calAnioNac.TabIndex = 8;
            this.calAnioNac.Value = new System.DateTime(2000, 1, 8, 0, 0, 0, 0);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(586, 148);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(265, 20);
            this.lblNacimiento.TabIndex = 9;
            this.lblNacimiento.Text = "Año de Nacimiento (>18): ";
            // 
            // cajaTextoMayInic2
            // 
            this.cajaTextoMayInic2.Location = new System.Drawing.Point(197, 32);
            this.cajaTextoMayInic2.Name = "cajaTextoMayInic2";
            this.cajaTextoMayInic2.Size = new System.Drawing.Size(822, 32);
            this.cajaTextoMayInic2.TabIndex = 4;
            // 
            // lblNomTitular
            // 
            this.lblNomTitular.AutoSize = true;
            this.lblNomTitular.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTitular.Location = new System.Drawing.Point(53, 39);
            this.lblNomTitular.Name = "lblNomTitular";
            this.lblNomTitular.Size = new System.Drawing.Size(91, 20);
            this.lblNomTitular.TabIndex = 7;
            this.lblNomTitular.Text = "Nombre:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(53, 90);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(107, 20);
            this.lblLocalidad.TabIndex = 5;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(197, 83);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(348, 32);
            this.txtLocalidad.TabIndex = 5;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(582, 50);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(426, 121);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.btnInscribirse.ForeColor = System.Drawing.Color.Black;
            this.btnInscribirse.Location = new System.Drawing.Point(59, 50);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(429, 121);
            this.btnInscribirse.TabIndex = 0;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.guardarDatos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTitulo.Location = new System.Drawing.Point(180, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(497, 60);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Datos del Equipo";
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(682, 83);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(337, 32);
            this.txtTlf.TabIndex = 6;
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlf.Location = new System.Drawing.Point(586, 90);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(41, 20);
            this.lblTlf.TabIndex = 15;
            this.lblTlf.Text = "Tlf:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 32);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(53, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 20);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-mail:";
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1208, 453);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción";
            this.tabPanel.ResumeLayout(false);
            this.tabEquipo.ResumeLayout(false);
            this.tabEquipo.PerformLayout();
            this.tabTitular.ResumeLayout(false);
            this.tabTitular.PerformLayout();
            this.tabFinal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdana12Negro lblNombre;
        private Verdana12Negro lblTitulo;
        private CajaTextoMay txtNombreEq;
        private Verdana12Negro lblColor;
        private CajaTextoMin txtColor;
        private Verdana12Negro lblLocalidad;
        private CajaTextoMayInic txtLocalidad;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabEquipo;
        private System.Windows.Forms.TabPage tabTitular;
        private System.Windows.Forms.TabPage tabFinal;
        private CajaTextoMayInic cajaTextoMayInic2;
        private Verdana12Negro lblNomTitular;
        private CajaTextoHexa txtCodigo;
        private Verdana12Negro lblCodigo;
        private Calendario calAnioNac;
        private Verdana12Negro lblNacimiento;
        private BotonVerdana btnInscribirse;
        private BotonVerdana btnBorrar;
        private CajaTextoNum txtTlf;
        private Verdana12Negro lblTlf;
        private CajaTextoEmail txtEmail;
        private Verdana12Negro lblEmail;
    }
}

