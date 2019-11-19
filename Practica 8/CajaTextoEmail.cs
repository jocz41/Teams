/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Generación de componentes.
* FECHA de ENTREGA.....: 10 de Enero de 2018
*/

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class CajaTextoEmail : TextBox
    {
        public CajaTextoEmail()
        {
            InitializeComponent();
            inicializar();
        }
        
        #region Eventos

        private void KeyPress_Email(object sender, KeyPressEventArgs e)
        {
            TextBox caja = (TextBox)sender;
            Regex reg = new Regex(@"^[a-zA-Z0-9_.-]*$");

            if (e.KeyChar != (char)(Keys.Back) && !reg.Match(e.KeyChar.ToString()).Success && e.KeyChar != '@')
                e.Handled = true;
            else if (caja.Text.Equals("") || caja.Text.EndsWith(" "))
            {
                if (!reg.Match(e.KeyChar.ToString()).Success)
                    e.Handled = true;            
            }
        }

        private void Leave_Email(object sender, EventArgs e)
        {
            TextBox caja = (TextBox)sender;
            string s = caja.Text.ToString();


            if (caja.Text.ToString().Length == 0)
            {
                MessageBox.Show("El campo no puede estar vacío (e-mail).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Select();
            }
            else
            {
                if (!s.Contains("@") || !comprobarCaracterUnico(s, '@')) 
                {
                    MessageBox.Show("E-mail erróneo.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Select();
                }
                else
                {
                    string subS = s.Substring(s.IndexOf('@'));

                    if (!subS.Contains(".") || !comprobarCaracterUnico(subS, '.'))
                    {
                        MessageBox.Show("E-mail erróneo.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.Select();
                    }
                }
            }
        }

        #endregion

        private bool comprobarCaracterUnico(string s, char c)
        {
            return (s.IndexOf(c) == s.LastIndexOf(c));
        }

        private void inicializar()
        {
            this.KeyPress += new KeyPressEventHandler(KeyPress_Email);
            this.Leave += new EventHandler(Leave_Email);
        }
        
    }
}
