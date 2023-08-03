using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;

namespace TPI_Datos
{
    public class CD_Comisiones
    {
        public CD_Comisiones() { }

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarComisiones()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM comisiones";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarComision(Comision com)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO comisiones VALUES('{com.Descripcion}','{com.AnioEspecialidad}','{com.IdPlan}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        //public void actualizarPersona(Persona per, string nomPer)
        //{
        //    comando.Connection = conexion.abrirConexion();
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = $"UPDATE personas SET nombre= '{per.Nombre}', apellido= '{per.Apellido}', direccion= '{per.Direccion}'," +
        //        $"email= '{per.Email}', telefono= '{per.Telefono}', fecha_nac= '{per.FechaNacimiento}', legajo= '{per.Legajo}', tipo_persona='{per.TipoPersona}'" +
        //        $" WHERE nombrePersona = '{nomPer}' ";
        //    comando.ExecuteNonQuery();
        //    conexion.cerrarConexion();
        //}

        public void eliminarComision(int idCom)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM comisiones WHERE id_comision='{idCom}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public DataTable mostrarComision(int idCom)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM comisiones WHERE id_comision = '{idCom}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }
    }
}
