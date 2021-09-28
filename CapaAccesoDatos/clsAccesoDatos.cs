using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{

    public class clsParametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection direccionParametro { get; set; }

        // Constructor parametros de entrada
        public clsParametros(string objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            direccionParametro = ParameterDirection.Input;
        }

        // Constructor parametros de salida
        public clsParametros(string objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            direccionParametro = ParameterDirection.Output;
        }

    }

    public class clsAccesoDatos
    {
    }
}
