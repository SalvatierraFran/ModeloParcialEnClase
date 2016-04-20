using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloParcial
{
    class Cliente
    {
        /* Crear alias
         * Crear el alias concatenando un numero random de cuatro cifras con la nacionalidad y el
         * tipo de cliente, invocar a este metodo en el constructor por defecto.
         * getAleas: retorna el aleas
         * Retornar datos (de instancia y privado) retorna un string con todos los datos.
         * Retornar datos (estatico y publico) retorna un string con todos los datos, utilizar el metodo de instancia*/

        private string _aliasParaIncognito;
        private string _nacionalidad;
        private string _nombre;
        private enumeradores.eTipoCliente _tipoDeCliente;

        Random rnd = new Random();

        private Cliente()
        {
            CrearAlias();
        }

        public Cliente(enumeradores.eTipoCliente cliente, string nombre)
        {
            this._tipoDeCliente = cliente;
            this._nombre = nombre;
        }

        public Cliente(enumeradores.eTipoCliente cliente, string nombre, string nacionalidad)
        {
            this._tipoDeCliente = cliente;
            this._nombre = nombre;
            this._nacionalidad = nacionalidad;
        }

        public Cliente(string nombre)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            int resultado;

            resultado = rnd.Next(1111, 9999);

            string _aliasParaIncognito = this.rnd + this._nacionalidad + this._tipoDeCliente;

        }

        public string getAlias()
        {
            if (this._aliasParaIncognito == null)
            {
                this.CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            string resultado;

            resultado = string.Concat(getAlias(), " - ", this._nacionalidad, " - ", this._nombre, " - ", this._tipoDeCliente);

            return resultado;
        }

        public string RetornarDatos(Cliente UnCliente)
        {
            return UnCliente.RetornarDatos();
        }
    }
}
