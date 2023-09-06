using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Datos;
using TPI_Entidades;

namespace TPI_Negocios
{
    public class CN_Usuario
    {
        public CN_Usuario() { }

        CD_Usuario CDUsuario = new CD_Usuario();
        Usuario usu = null;

        public void agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email, int idPersona)
        {
            Usuario usu = new Usuario(nomUsu, clave, nombre, apellido, email, idPersona);
            this.CDUsuario.agregarUsuario(usu);
        }

        public Usuario validarUsuario(string nomUsu, string pass)
        {
            DataTable dt = CDUsuario.validarUsuario(nomUsu, pass);
            if(dt.Rows.Count > 0)
            {
                usu = new Usuario(dt.Rows[0]["nombre_usuario"].ToString(), dt.Rows[0]["clave"].ToString(), dt.Rows[0]["nombre"].ToString(), dt.Rows[0]["apellido"].ToString(),
               dt.Rows[0]["email"].ToString(), (int)dt.Rows[0]["id_persona"]);
            }
            else
            {
                usu = null;
            }
            return usu;
        }

        public DataTable mostrarUsuarios()
        {
            return this.CDUsuario.mostrarUsuarios();
        }

        public DataTable mostrarUsuariosCompleto()
        {
            return this.CDUsuario.mostrarUsuariosCompleto();
        }

        public DataTable mostrarUsuario(string nomUsu)
        {
            return this.CDUsuario.mostrarUsuario(nomUsu);
        }

        public void eliminarUsuario(string nomUsu)
        {
            this.CDUsuario.eliminarUsuario(nomUsu);
        }

        public void actualizarUsuario(string nomUsu, Usuario usu)
        {
            this.CDUsuario.actualizarUsuario(usu, nomUsu);
        }

      

    }
}
