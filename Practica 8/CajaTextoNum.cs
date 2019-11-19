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
    public partial class CajaTextoNum : TextBox
    {
        public CajaTextoNum()
        {
            InitializeComponent();
            inicializar();
        }
        
        #region Eventos

        private void KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)(Keys.Back) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Leave_Num(object sender, EventArgs ev)
        {
            TextBox caja = (TextBox)sender;
            int longitud = caja.Text.ToString().Length;

            if (longitud == 0)
            {
                MessageBox.Show("El campo no puede estar vacío (numérico).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Select();
            }
            else if (longitud != 9)
            {
                MessageBox.Show("El campo debe contener 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Select();
            }
        }

        #endregion

        private void inicializar()
        {
            this.KeyPress += new KeyPressEventHandler(KeyPress_Num);
            this.Leave += new EventHandler(Leave_Num);
        }
    }
}
