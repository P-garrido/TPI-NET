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
    public class CD_Especialidad
    {

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarEspecialidades()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM Especialidades";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarEspecialidad(string descEspecialidad)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM especialidades WHERE desc_especialidad = '{descEspecialidad}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }
        public DataTable mostrarEspecialidadId(int idEspecialidad)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM especialidades WHERE id_especialidad = '{idEspecialidad}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarEspecialidad(Especialidad esp)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO especialidades VALUES('{esp.Descripcion}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarEspecialidad(Especialidad esp, string nomEsp)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE especialidades SET desc_especialidad= '{esp.Descripcion}' WHERE desc_especialidad = '{nomEsp}' ";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void eliminarEspecialidad(string nomEsp)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM especialidades WHERE desc_especialidad='{nomEsp}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }
    }
}
