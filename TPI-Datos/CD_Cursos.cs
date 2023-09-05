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
    public class CD_Cursos
    {
        public CD_Cursos() { }

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarCursos()
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM cursos";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarCursosCompleto()
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_curso 'ID Curso', desc_materia Materia, desc_comision Comisión, anio_calendario 'Año Calendario', cupo Cupo FROM cursos cur " +
                                  "INNER JOIN materias mat ON cur.id_materia = mat.id_materia INNER JOIN comisiones com ON com.id_comision = cur.id_comision";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarCurso(Curso cur)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO cursos VALUES('{cur.IdMateria}','{cur.IdComision}','{cur.AnioCalendario}','{cur.Cupo}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarCurso(Curso cur, int idCurso )
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE cursos SET id_materia= '{cur.IdMateria}', id_comision= '{cur.IdComision}', anio_calendario= '{cur.AnioCalendario}'," +
                $"cupo= '{cur.Cupo}' WHERE id_curso= '{idCurso}' ";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void eliminarCurso(int idCurso)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM cursos WHERE id_curso='{idCurso}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public DataTable mostrarCurso(int idCurso)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM cursos WHERE id_curso= '{idCurso}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }
    }
}
