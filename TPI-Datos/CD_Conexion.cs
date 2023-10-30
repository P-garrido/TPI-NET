using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;
using System.Data.SqlClient;

namespace TPI_Datos
{
    public class CD_Conexion
    {

        public CD_Conexion() { }

        public SqlConnection Conexion
        {
            get => conexion;
        }


        private SqlConnection conexion = new SqlConnection("Data Source=MS-06\\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True");


        public SqlConnection abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
