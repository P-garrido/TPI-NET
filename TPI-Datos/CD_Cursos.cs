using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;
using System.Reflection.PortableExecutable;
using System.Reflection;

namespace TPI_Datos
{
    public class CD_Cursos
    {
        public CD_Cursos() { }

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter idAlumno;
        SqlParameter idComision;
        SqlParameter idMateria;

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

        public DataTable mostrarCursosCompletoPorMateria(int idMat, int idAlu)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = $"SELECT * FROM cursos cu INNER JOIN comisiones co ON cu.id_comision=co.id_comision WHERE cu.id_materia='{idMat}' AND cu.cupo>0 AND cu.id_curso NOT IN(SELECT id_curso FROM alumnos_inscripciones WHERE id_alumno='{idAlu}');";

            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }


        //public DataTable buscarCurso(int idMat, int idCom)
        //{
        //    comando.Connection = conexion.abrirConexion();
        //    table.Clear();
        //    comando.CommandType = CommandType.Text;
        //    SqlParameter idMate = new SqlParameter("@idMat", SqlDbType.Int);
        //    idMate.Direction = ParameterDirection.Input;
        //    idMate.Value = idMat;
        //    comando.Parameters.Add(idMate);
        //    SqlParameter idComi = new SqlParameter("@idCom", SqlDbType.Int);
        //    idMate.Direction = ParameterDirection.Input;
        //    idComi.Value = idCom;
        //    comando.Parameters.Add(idComi);

        //    comando.CommandText = "SELECT * FROM cursos WHERE id_materia= 3 AND id_comision= 2";
        //    reader = comando.ExecuteReader();
        //    table.Load(reader);
        //    conexion.cerrarConexion();
        //    return table;
        //}

        public List<TPI_Entidades.Curso> buscarCurso(int idMat, int idCom)
        {
            List<TPI_Entidades.Curso> lista = new List<TPI_Entidades.Curso>();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            SqlParameter idMate = new SqlParameter("@idMat", SqlDbType.Int);
            idMate.Direction = ParameterDirection.Input;
            idMate.Value = idMat;
            comando.Parameters.Add(idMate);
            SqlParameter idComi = new SqlParameter("@idCom", SqlDbType.Int);
            idMate.Direction = ParameterDirection.Input;
            idComi.Value = idCom;
            comando.Parameters.Add(idComi);

            comando.CommandText = "SELECT * FROM cursos WHERE id_materia= @idMat AND id_comision= @idCom";
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                TPI_Entidades.Curso unCurso = new TPI_Entidades.Curso();
                unCurso.IdCurso = (int)reader.GetValue(0);
                lista.Add(unCurso);
            }
            conexion.cerrarConexion();
            return lista;
        }

        public DataTable mostrarCursosSinDocente(int idMat)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = $"SELECT * FROM cursos cur INNER JOIN materias mat ON cur.id_materia = mat.id_materia INNER JOIN comisiones com ON com.id_comision = cur.id_comision WHERE cur.id_materia='{idMat}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public AlumnoInscripcion buscarInscripcion(int idAlu, int idCom, int idMat)
        {
            AlumnoInscripcion inscripcion = new AlumnoInscripcion();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
            idAlumno = new SqlParameter("@idAlu", SqlDbType.Int);
            idAlumno.Direction = ParameterDirection.Input;
            idAlumno.Value = idAlu;
            comando.Parameters.Add(idAlumno);
            idComision = new SqlParameter("@idCom", SqlDbType.Int);
            idComision.Direction = ParameterDirection.Input;
            idComision.Value = idCom;
            comando.Parameters.Add(idComision);
            idMateria = new SqlParameter("@idMat", SqlDbType.Int);
            idMateria.Direction = ParameterDirection.Input;
            idMateria.Value = idMat;
            comando.Parameters.Add(idMateria);
            comando.CommandText = "SELECT id_inscripcion, alu.id_alumno, alu.id_curso, condicion FROM alumnos_inscripciones alu " +
                "INNER JOIN cursos cur ON alu.id_curso = cur.id_curso WHERE alu.id_alumno = @idAlu AND cur.id_comision = @idCom " +
                "AND cur.id_materia = @idMat";
            reader = comando.ExecuteReader();
            reader.Read();
            inscripcion.IdInscripcion = (int) reader.GetValue(0);
            inscripcion.IdAlumno = (int)reader.GetValue(1);
            inscripcion.IdCurso = (int)reader.GetValue(2);
            inscripcion.Condicion = (string)reader.GetValue(3);
            comando.Connection = conexion.cerrarConexion();
            return inscripcion;
        }

        public DataTable cargarReporteCursos()
        {
            conexion.abrirConexion();
            SqlCommand comando = new SqlCommand("select * from cursos;", conexion.Conexion);
            SqlDataAdapter d = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            d.Fill(dt);
            conexion.cerrarConexion();
            return dt;
        }
    }
}
