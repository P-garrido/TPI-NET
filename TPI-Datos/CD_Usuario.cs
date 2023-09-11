using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;

namespace TPI_Datos
{
    public class CD_Usuario
    {

        public CD_Usuario() { }

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarUsuarios()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT * FROM usuarios";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable mostrarUsuariosCompleto()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_usuario 'ID Usuario', nombre_usuario 'Nombre de Usuario', clave 'Clave', " +
                "habilitado 'Habilitado', nombre 'Nombre', apellido 'Apellido', email 'Email', cambia_clave 'Cambia Clave'" +
                ", id_persona 'ID Persona' FROM usuarios ";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarUsuario(Usuario usu)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO usuarios VALUES('{usu.NombreUsuario}','{usu.Clave}',{1},'{usu.Nombre}','{usu.Apellido}','{usu.Email}',{0},'{usu.IdPersona}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarUsuario(Usuario usu, string nomUsu)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE usuarios SET nombre_usuario= '{usu.NombreUsuario}', clave= '{usu.Clave}', nombre= '{usu.Nombre}'," +
                $"apellido= '{usu.Apellido}', email= '{usu.Email}', idPersona= '{usu.IdPersona}' WHERE nombreUsuario = '{nomUsu}' ";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void eliminarUsuario(string nomUsu)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE FROM usuarios WHERE nombre_usuario='{nomUsu}'";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public DataTable mostrarUsuario(string nomUsu)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM usuarios WHERE nombre_usuario = '{nomUsu}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public DataTable validarUsuario(string nomUsu, string pass)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = $"SELECT * FROM usuarios WHERE nombre_usuario= '{nomUsu}' AND clave='{pass}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }


    }
}
