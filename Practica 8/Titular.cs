/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Generación de componentes.
* FECHA de ENTREGA.....: 10 de Enero de 2018
*/

using System;

namespace Practica_8
{
    [Serializable]
    public class Titular
    {
        #region Atributos

        private string nombre, email, localidad, anioNacimiento;
        private uint tlf;

        #endregion

        public Titular(string nombre, string email, string localidad, uint tlf, string anioNacimiento)
        {
            this.nombre = nombre;
            this.email = email;
            this.localidad = localidad;
            this.tlf = tlf;
            this.anioNacimiento = anioNacimiento;
        }

        #region Propiedades

        public string Nombre
        {
            get => nombre;
        }

        public string Email
        {
            get => email;
        }

        public string Localidad
        {
            get => localidad;
        }

        public uint Tlf
        {
            get => tlf;
        }

        public string AnioNacimiento
        {
            get => anioNacimiento;
        }

        #endregion
    }
}
