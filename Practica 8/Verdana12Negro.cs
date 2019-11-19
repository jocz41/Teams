/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Generación de componentes.
* FECHA de ENTREGA.....: 10 de Enero de 2018
*/

using System.Windows.Forms;

namespace Practica_8
{
    public partial class Verdana12Negro : Label
    {
        public Verdana12Negro()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
