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
    public partial class Calendario : DateTimePicker
    {
        public Calendario()
        {
            InitializeComponent();
            inicializar();
        }
        
        private DateTime maxFecha()
        {
            DateTime t = System.DateTime.Now;

            return new DateTime(t.Year - 18, t.Month, t.Day);
        }

        private void inicializar()
        {
            this.MaxDate = maxFecha();
            this.MinDate = new DateTime(1900, 1, 1);
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "yyyy";
            this.ShowUpDown = true;
        }
    }
}
