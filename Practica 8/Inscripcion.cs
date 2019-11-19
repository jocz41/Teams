/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Generación de componentes.
* FECHA de ENTREGA.....: 10 de Enero de 2018
*/

using System;
using System.IO;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        #region Eventos

        public void cambiaPestania(object sender, TabControlCancelEventArgs ev)
        {
            TabPage tabSelec = (TabPage)this.tabPanel.SelectedTab;
            bool completo = true;
            int i = 0;            

            while (i < tabSelec.Controls.Count && completo)
            {
                if (tabSelec.Controls[i] is TextBox)
                    completo = (tabSelec.Controls[i].Text.Length > 0);
                i++;
            }
            
            if (!completo)
            {
                ev.Cancel = true;
                MessageBox.Show("Uno o más campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void guardarDatos_Click(object sender, EventArgs ev)
        {
            buscarFicha();
        }

        public void borrar_Click(object sender, EventArgs ev)
        {
            limpiarCampos();
        }

        #endregion

        private Ficha generarFicha()
        {
            Titular t = null;

            t = new Titular(this.txtNombreEq.Text.ToString(), this.txtEmail.Text.ToString(), this.txtLocalidad.Text.ToString(),
                            uint.Parse(this.txtTlf.Text.ToString()), this.calAnioNac.Value.ToString());

            return new Ficha(this.txtNombreEq.Text.ToString(), this.txtColor.Text.ToString(), this.txtCodigo.Text.ToString(), t);
        }

        public void buscarFicha()
        {
            string nombre, ruta;

            nombre = this.txtNombreEq.Text.ToString();
            ruta = @"..\..\..\" + nombre + ".dat";

            if (File.Exists(ruta))
            {                
                MessageBox.Show("Ya existe un equipo con el nombre indicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comprobarCampos())
            {
                Ficha f = generarFicha();
                f.creaFichero();

                MessageBox.Show("Equipo inscrito con éxito.", "Inscrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
            else
            {                    
                MessageBox.Show("Error al inscribir, uno o más campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void limpiarCampos()
        {
            foreach (TabPage tab in this.tabPanel.TabPages)
            {
                foreach (Control c in tab.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
            }

            this.tabPanel.SelectedIndex = tabEquipo.TabIndex;
        }

        private bool comprobarCampos()
        {
            bool completo = true;
            int i = 0, j;

            while (i < this.tabPanel.TabPages.Count && completo)
            {
                TabPage tabSelec = this.tabPanel.TabPages[i];
                j = 0;

                while (j < tabSelec.Controls.Count && completo)
                {
                    if (tabSelec.Controls[j] is TextBox)
                        completo = (tabSelec.Controls[j].Text.Length > 0);
                    j++;
                }

                i++;
            }

            return completo;
        }
    }
}
