using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Collections;

namespace TPI_Datos
{
    public class CD_Materia
    {
        public CD_Materia() { }
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter idComision;
        SqlParameter descMateria;

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

        public List<Materia> buscarMateriasPorComision(int idCom)
        {
            List<Materia> lista = new List<Materia>();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
            idComision = new SqlParameter("@idCom", SqlDbType.Int);
            idComision.Direction = ParameterDirection.Input;
            idComision.Value = idCom;
            comando.Parameters.Add(idComision);
            comando.CommandText = "SELECT mat.id_materia, mat.desc_materia FROM comisiones com INNER JOIN cursos cur " +
                "ON cur.id_comision = com.id_comision INNER JOIN materias mat ON mat.id_materia = cur.id_materia " +
                "WHERE com.id_comision = @idCom";
            reader = comando.ExecuteReader();
            while(reader.Read())
            {
                Materia unaMateria = new Materia();
                unaMateria.IdMateria= (int)reader.GetValue(0);
                unaMateria.Descripcion = (string)reader.GetValue(1);
                lista.Add(unaMateria);
            }
            comando.Connection = conexion.cerrarConexion();
            return lista;
        }

        public Materia buscarMateriaPorDescripcion(string desc)
        {
            Materia materia = new Materia();
            comando.Parameters.Clear();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandType = CommandType.Text;
            descMateria = new SqlParameter("@descMat", SqlDbType.VarChar);
            descMateria.Direction = ParameterDirection.Input;
            descMateria.Value = desc;
            comando.Parameters.Add(descMateria);
            comando.CommandText = "SELECT * FROM materias mat WHERE mat.desc_materia = @descMat";
            reader = comando.ExecuteReader();
            reader.Read();
            materia.IdMateria = (int)reader.GetValue(0);
            materia.Descripcion = (string)reader.GetValue(1);
            materia.HorasSemanales = (int)reader.GetValue(2);
            materia.HorasTotales = (int)reader.GetValue(3);
            materia.IdPlan = (int)reader.GetValue(4);
            comando.Connection = conexion.cerrarConexion();
            return materia;
        }

        public List<MateriaCompleto> mostrarMateriasEntidad()
        {
            List<MateriaCompleto> mats = new List<MateriaCompleto>();
            comando.Connection = conexion.abrirConexion();
            table.Clear();
            comando.CommandText = "SELECT id_materia 'ID Materia', desc_materia Nombre, hs_semanales 'Horas Semanales', hs_totales 'Horas Totales'," +
                "desc_plan 'Plan de Estudios' FROM materias mat INNER JOIN planes pla ON pla.id_plan = mat.id_plan";
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                MateriaCompleto materia = new MateriaCompleto((string)reader.GetValue(1), (int)reader.GetValue(2), (int)reader.GetValue(3), (string)reader.GetValue(4));
                materia.IdMateria = (int)reader.GetValue(0);
                mats.Add(materia);
            }
            conexion.cerrarConexion();
            return mats;
        }


    }
}
