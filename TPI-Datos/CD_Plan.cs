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
    public class CD_Plan
    {

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarPlanes()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM planes";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarPlanesCompleto()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_plan 'ID Plan', desc_plan 'Descripción', desc_especialidad 'Especialidad' FROM planes pla INNER JOIN especialidades esp ON esp.id_especialidad = pla.id_especialidad";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarPlan(string descPlan)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM planes WHERE desc_plan = '{descPlan}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }


        public void agregarPlan(Plan pla)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO planes VALUES('{pla.Descripcion}','{pla.IdEspecialidad}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarPlan(Plan pla, string nomPla)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE planes SET desc_plan= '{pla.Descripcion}', id_especialidad= '{pla.IdEspecialidad}' WHERE desc_plan = '{nomPla}' ";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void eliminarPlan(int idPlan)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM planes WHERE id_plan='{idPlan}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public DataTable cargarReportePlanes()
        {
            conexion.abrirConexion();
            SqlCommand comando = new SqlCommand("select * from planes;", conexion.Conexion);
            SqlDataAdapter d = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            d.Fill(dt);
            conexion.cerrarConexion();
            return dt;
        }
    }
}
