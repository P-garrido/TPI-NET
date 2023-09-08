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

        public void agregarPersona(Persona per)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO Personas VALUES('{per.Nombre}','{per.Apellido}','{per.Direccion}','{per.Email}','{per.Telefono}','{per.FechaNacimiento}'," +
                $"'{per.Legajo}','{per.TipoPersona}','{per.IdPlan}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarPersona(Persona per, string nomPer)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE personas SET nombre= '{per.Nombre}', apellido= '{per.Apellido}', direccion= '{per.Direccion}'," +
                $"email= '{per.Email}', telefono= '{per.Telefono}', fecha_nac= '{per.FechaNacimiento}', legajo= '{per.Legajo}', tipo_persona='{per.TipoPersona}'" +
                $" WHERE nombrePersona = '{nomPer}' ";
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
