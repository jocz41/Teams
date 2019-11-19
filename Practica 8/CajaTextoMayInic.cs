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
    public partial class CajaTextoMayInic : TextBox
    {
        public CajaTextoMayInic()
        {
            InitializeComponent();
            inicializar();
        }

        #region Eventos

        private void KeyPress_MayInic(object sender, KeyPressEventArgs e)
        {
            TextBox caja = (TextBox) sender;

            if (e.KeyChar != (char)(Keys.Back) && e.KeyChar != (char)(Keys.Space) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsLetter(e.KeyChar))
            {
                if (caja.Text.Equals("") || caja.Text.EndsWith(" "))
                {
                    if (!Mayuscula(e))
                        e.Handled = true;
                }
                else
                {
                    if (Mayuscula(e))
                        e.Handled = true;
                }
            }
        }

        private void Leave_MayInic(object sender, EventArgs ev)
        {
            TextBox caja = (TextBox)sender;

            if (caja.Text.ToString().Length == 0)
            {
                MessageBox.Show("El campo no puede estar vacío (Inicial Mayúscula).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Select();
            }
        }

        #endregion        

        private bool Mayuscula(KeyPressEventArgs e)
        {
            return (e.KeyChar >= 'A' && e.KeyChar <= 'Z');
        }
        
        private void inicializar()
        {
            this.KeyPress += new KeyPressEventHandler(KeyPress_MayInic);
            this.Leave += new EventHandler(Leave_MayInic);
        }
    }
}
