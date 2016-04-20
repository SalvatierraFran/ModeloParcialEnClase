using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloParcial
{
    class CuentaOffShore
    {
        /*En esta clase el constructor por defecto debera sumar 1 al atributo estatico
        cantidad de cuenta y en lugar por defecto sera Bahamas, no repetir lineas de codigo.
        Constructor de clase en esta clase sera el encargado de inicializar la cantidad de cuentas
        a cero*/

        private enumeradores.eTipoBeneficio beneficio;
        public static int CantidadDeCuentas;
        private enumeradores.eParaisosFiscales lugar;
        private List<Cliente> _ListadoClientes;

        public CuentaOffShore()
        {
            CantidadDeCuentas = CantidadDeCuentas + 1;
            this.lugar = enumeradores.eParaisosFiscales.Bahamas;
        }

        static CuentaOffShore()
        {
            CantidadDeCuentas = 0;
        }

        public CuentaOffShore(enumeradores.eParaisosFiscales Lugar)
        {
            this.lugar = Lugar;
        }

        public CuentaOffShore(enumeradores.eParaisosFiscales Lugar, enumeradores.eTipoBeneficio Beneficio)
        {
            this.lugar = Lugar;
            this.beneficio = Beneficio;
        }

        public void FiltrarTodosLosDatos()
        { }

        public int getCantidadDeClientes()
        {
            int cantidad;

            cantidad = this._ListadoClientes.Count();

            return cantidad;
        }

        private void MostrarClientes()
        {
            foreach (Cliente item in this._ListadoClientes)
            {
                Console.WriteLine(item.RetornarDatos());
            }
        }

        public static bool operator !=(CuentaOffShore cuenta, Cliente cliente)
        { }

        public static CuentaOffShore operator +(CuentaOffShore cuenta, Cliente cliente)
        { }

        public static bool operator ==(CuentaOffShore cuenta, Cliente cliente)
        { }
    }
}

namespace enumeradores
{
    public enum eParaisosFiscales
    {
        Anguila, Bahamas, Belice, Delaware, Gibraltar, Hong_Kong, Mauricio, Panamá, Seychelles, Singapur, Suiza
    }

    public enum eTipoProducto
    {
        cuentas_bancarias, pólizas_de_seguros, inversiones_inmoviliarias, sociedades_extranjeras, fondos_de_inversion
    }

    public enum eTipoBeneficio
    {
        secreto_bancario, beneficios_fiscales, secreto_bancario_y_beneficios_fiscales
    }

    public enum eTipoCliente
    {
        PolíticoCorrupto, EmpresarioCorrupto, jugadorDeFutbol, financista, maestroRural
    }
}
