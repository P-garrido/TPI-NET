using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;
using System.Security.Cryptography;

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

        public DataTable mostrarComisionesCompleto()
        {

            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_comision 'ID Comision', desc_comision Descripción , anio_especialidad 'Año Especialidad' , desc_plan 'Plan de Estudios' FROM comisiones com INNER JOIN planes pla ON pla.id_plan = com.id_plan";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }

        public void agregarComision(Comision com)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"INSERT INTO comisiones (desc_comision, anio_especialidad, id_plan) VALUES('{com.Descripcion}','{com.AnioEspecialidad}','{com.IdPlan}')";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void actualizarComision(Comision com, int idCom)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"UPDATE comisiones SET desc_comision= '{com.Descripcion}', anio_especialidad= '{com.AnioEspecialidad}', id_plan= '{com.IdPlan}' WHERE id_comision = '{idCom}' ";
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

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

        public DataTable mostrarComisionPorDescripcion(string descCom)
        {
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT * FROM comisiones WHERE desc_comision = '{descCom}'";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.cerrarConexion();
            return table;
        }


        //public DataTable mostrarComisionesConCurso()
        //{
        //    comando.Connection = conexion.abrirConexion();
        //    table.Clear();
        //    comando.CommandText = "SELECT * FROM comisiones com INNER JOIN cursos cur ON com.id_comision=cur.id_comision";
        //    reader = comando.ExecuteReader();
        //    table.Load(reader);
        //    conexion.cerrarConexion();
        //    return table;
        //}

        

    }
}
