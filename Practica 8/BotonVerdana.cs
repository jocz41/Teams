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
    public partial class BotonVerdana : Button
    {
        public BotonVerdana()
        {
            InitializeComponent();
            inicializar();
        }

        public void inicializar()
        {
            this.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
        }
    }
}
