﻿/*
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
    public partial class CajaTextoMay : TextBox
    {
        public CajaTextoMay()
        {
            InitializeComponent();
            inicializar();
        }

        public void inicializar()
        {
            this.KeyPress += new KeyPressEventHandler(KeyPress_May);
            this.Leave += new EventHandler(Leave_May);
        }

        #region Eventos

        private void KeyPress_May(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)(Keys.Back) && e.KeyChar != (char)(Keys.Space) && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
                e.Handled = true;
        }

        private void Leave_May(object sender, EventArgs ev)
        {
            TextBox caja = (TextBox) sender;

            if (caja.Text.ToString().Length == 0)
            {
                MessageBox.Show("El campo no puede estar vacío (MAYÚSCULAS).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Select();
            }
        }

        #endregion
    }
}
