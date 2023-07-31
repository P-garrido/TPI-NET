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

        public void agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email, int idPersona)
        {
            Usuario usu = new Usuario(nomUsu, clave, nombre, apellido, email, idPersona);
            this.CDUsuario.agregarUsuario(usu);
        }

        public DataTable mostrarUsuarios()
        {
            return this.CDUsuario.mostrarUsuarios();
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
