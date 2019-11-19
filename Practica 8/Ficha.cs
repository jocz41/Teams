/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Generación de componentes.
* FECHA de ENTREGA.....: 10 de Enero de 2018
*/

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica_8
{
    [Serializable]
    public class Ficha
    {
        #region Atributos

        private string nombreEq, colorEq, codigo;
        private Titular titular;

        #endregion

        public Ficha(string nombreEq, string colorEq, string codigo, Titular titular)
        {
            this.nombreEq = nombreEq;
            this.colorEq = colorEq;
            this.codigo = codigo;
            this.titular = titular;
        }

        #region Propiedades

        public string NombreEq
        {
            get => nombreEq;
        }

        public string ColorEq
        {
            get => colorEq;
        }

        public string Codigo
        {
            get => codigo;
        }

        internal Titular Titular
        {
            get => titular;
        }

        #endregion 

        public void creaFichero()
        {
            FileStream fs = new FileStream(@"..\..\..\" + this.NombreEq + ".dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
