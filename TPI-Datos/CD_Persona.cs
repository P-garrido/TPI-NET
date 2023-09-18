using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;
using System.Runtime.ConstrainedExecution;

namespace TPI_Datos
{
    public class CD_Persona
    {

        public CD_Persona() { }

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarPersonas()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM personas";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarPersonasCompleto()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_persona 'ID Persona', nombre 'Nombre', apellido 'Apellido', direccion 'Dirección', " +
                "email 'Email', telefono 'Teléfono', fecha_nac 'Fecha de Nacimiento', legajo 'Legajo', tipo_persona 'Tipo de Persona', desc_plan 'Plan'" +
                "FROM personas per INNER JOIN planes pla ON per.id_plan = pla.id_plan";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarPersona(Persona per)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            SqlParameter paramFecha = new SqlParameter("@Fecha", SqlDbType.DateTime);
            paramFecha.Direction = ParameterDirection.Input;
            paramFecha.Value = per.FechaNacimiento;
            comando.Parameters.Add(paramFecha);
            comando.CommandText = $"INSERT INTO Personas VALUES('{per.Nombre}','{per.Apellido}','{per.Direccion}','{per.Email}','{per.Telefono}', @Fecha," +
                $"'{per.Legajo}','{per.TipoPersona}','{per.IdPlan}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarPersona(Persona per, string nomPer)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            SqlParameter paramFecha = new SqlParameter("@Fecha", SqlDbType.DateTime);
            paramFecha.Direction= ParameterDirection.Input;
            paramFecha.Value = per.FechaNacimiento;
            comando.Parameters.Add(paramFecha);
            comando.CommandText = $"UPDATE personas SET nombre= '{per.Nombre}', apellido= '{per.Apellido}', direccion= '{per.Direccion}'," +
                $"email= '{per.Email}', telefono= '{per.Telefono}', fecha_nac= @Fecha, legajo= '{per.Legajo}', tipo_persona='{per.TipoPersona}'" +
                $" WHERE nombre = '{nomPer}' ";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void eliminarPersona(string nomPer)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM personas WHERE nombre='{nomPer}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public DataTable mostrarPersona(int legPer)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM Personas WHERE legajo = '{legPer}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable buscarPersona(int idPer)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM Personas WHERE id_persona = '{idPer}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void inscribirACurso(int idAlumno, int idCurso)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO alumnos_inscripciones (id_alumno, id_curso, condicion) VALUES('{idAlumno}','{idCurso}', 'Cursando')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }
    }
}
