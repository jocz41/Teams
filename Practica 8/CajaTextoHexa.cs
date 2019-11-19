/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Generación de componentes.
* FECHA de ENTREGA.....: 10 de Enero de 2018
*/

using System;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class CajaTextoHexa : TextBox
    {
        public CajaTextoHexa()
        {
            InitializeComponent();
            inicializar();
        }
                
        #region Eventos

        private void KeyPress_Hexa(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)(Keys.Back))
            {
                e.KeyChar = (char.IsLetter(e.KeyChar)) ? char.ToUpper(e.KeyChar) : e.KeyChar;

                if (!char.IsDigit(e.KeyChar) && e.KeyChar < 'A' || e.KeyChar > 'F')
                    e.Handled = true;
            }
        }

        private void Leave_Hexa(object sender, EventArgs ev)
        {
            TextBox caja = (TextBox)sender;

            if (caja.Text.ToString().Length == 0)
            {
                MessageBox.Show("El campo no puede estar vacío (hexadecimal).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Select();
            }
        }

        #endregion

        private void inicializar()
        {
            this.KeyPress += new KeyPressEventHandler(KeyPress_Hexa);
            this.Leave += new EventHandler(Leave_Hexa);
        }

    }
}
