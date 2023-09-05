using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;
using System.ComponentModel.DataAnnotations;

namespace TPI_Datos
{
    public class CD_Materia
    {
        public CD_Materia() { }
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarMaterias()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM materias";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarMateriasCompleto()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_materia 'ID Materia', desc_materia Nombre, hs_semanales 'Horas Semanales', hs_totales 'Horas Totales'," +
                "desc_plan 'Plan de Estudios' FROM materias mat INNER JOIN planes pla ON pla.id_plan = mat.id_plan";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarMateria(Materia mat)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;  
            comando.CommandText = $"INSERT INTO materias VALUES('{mat.Descripcion}','{mat.HorasSemanales}','{mat.HorasTotales}','{mat.IdPlan}')"; 
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarMateria(Materia mat, string descMat)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE materias SET desc_materia= '{mat.Descripcion}', hs_semanales= '{mat.HorasSemanales}', hs_totales= '{mat.HorasTotales}'," +
                $"id_plan= '{mat.IdPlan}' WHERE desc_materia = '{descMat}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void eliminarMateria(int idMat)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM materias WHERE id_materia='{idMat}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public DataTable mostrarMateria(string descMat)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM materias WHERE desc_materia= '{descMat}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarMateriaPorId(int idMat)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM materias WHERE id_materia= '{idMat}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }
    }
}
