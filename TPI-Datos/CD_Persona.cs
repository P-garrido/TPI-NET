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
        SqlParameter idComision;
        SqlParameter idMateria;
        SqlParameter nombreApellido;
        SqlParameter idInscripcion;
        SqlParameter nota;

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
            SqlParameter paramFecha = new SqlParameter("@FechaNacimientoGuardar", SqlDbType.DateTime);
            paramFecha.Direction = ParameterDirection.Input;
            paramFecha.Value = per.FechaNacimiento;
            comando.Parameters.Add(paramFecha);
            comando.CommandText = $"INSERT INTO Personas VALUES('{per.Nombre}','{per.Apellido}','{per.Direccion}','{per.Email}','{per.Telefono}', @FechaNacimientoGuardar," +
                $"'{per.Legajo}','{per.TipoPersona}','{per.IdPlan}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarPersona(Persona per, string nomPer)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            SqlParameter paramFecha = new SqlParameter("@FechaNacimientoActualizar", SqlDbType.DateTime);
            paramFecha.Direction= ParameterDirection.Input;
            paramFecha.Value = per.FechaNacimiento;
            comando.Parameters.Add(paramFecha);
            comando.CommandText = $"UPDATE personas SET nombre= '{per.Nombre}', apellido= '{per.Apellido}', direccion= '{per.Direccion}'," +
                $"email= '{per.Email}', telefono= '{per.Telefono}', fecha_nac= @FechaNacimientoActualizar, legajo= '{per.Legajo}', tipo_persona='{per.TipoPersona}'" +
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

        public void inscribirDocenteACurso(int idDoc, int idCur, int cargo)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO docentes_cursos (id_curso, id_docente, cargo) VALUES('{idCur}','{idDoc}', '{cargo}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public List<Persona> buscarAlumnosCursando(int idCom, int idMat)
        {
            List<Persona> lista = new List<Persona> ();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
            idComision = new SqlParameter("@idCom", SqlDbType.Int);
            idComision.Direction = ParameterDirection.Input;
            idComision.Value = idCom;
            idMateria = new SqlParameter("@idMat", SqlDbType.Int);
            idMateria.Direction = ParameterDirection.Input;
            idMateria.Value = idMat;
            comando.Parameters.Add(idComision);
            comando.Parameters.Add(idMateria);
            comando.CommandText = "SELECT per.id_persona, per.nombre, per.apellido FROM cursos cur INNER JOIN alumnos_inscripciones alu ON cur.id_curso = alu.id_curso INNER JOIN personas per ON per.id_persona = alu.id_alumno WHERE cur.id_materia = @idMat AND cur.id_comision = @idCom ";
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona unAlumno = new Persona();
                unAlumno.idPersona= (int)reader.GetValue(0);
                unAlumno.Nombre= (string)reader.GetValue(1);
                unAlumno.Apellido= (string)reader.GetValue(2);  
                lista.Add(unAlumno);
            }
            comando.Connection = conexion.cerrarConexion();
            return lista;
        }

        public Persona buscarAlumnoNombreApellido(string nomAp)
        {
            Persona persona = new Persona();
            comando.Parameters.Clear();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            nombreApellido = new SqlParameter("@nomAp", SqlDbType.VarChar);
            nombreApellido.Direction = ParameterDirection.Input;
            nombreApellido.Value = nomAp;
            comando.Parameters.Add(nombreApellido);
            comando.CommandText = "SELECT id_persona, nombre, apellido FROM personas per WHERE concat(nombre, ' ', apellido)= @nomAp";
            reader = comando.ExecuteReader();
            reader.Read();
            persona.idPersona = (int)reader.GetValue(0);
            persona.Nombre = (string)reader.GetValue(1);
            persona.Apellido = (string)reader.GetValue(2);  
            comando.Connection = conexion.cerrarConexion();
            return persona;
        }

        public void actualizarNota(int idInsc, int notaDada)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            idInscripcion = new SqlParameter("@idInsc", SqlDbType.Int);
            idInscripcion.Direction = ParameterDirection.Input;
            idInscripcion.Value = idInsc;
            nota = new SqlParameter("@nota", SqlDbType.Int);
            nota.Direction = ParameterDirection.Input;
            nota.Value = notaDada;
            comando.Parameters.Add(nota);
            comando.Parameters.Add(idInscripcion);
            comando.CommandText = "UPDATE alumnos_inscripciones SET nota = @nota WHERE id_inscripcion = @idInsc";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
        }
    }
}
