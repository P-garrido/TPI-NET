using System;
using System.Collections.Generic;
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

        public bool agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email)
        {
            return this.CDUsuario.agregarUsuario(nomUsu, clave, nombre, apellido, email);
        }

        public List<Usuario> mostrarUsuarios()
        {
            return this.CDUsuario.mostrarUsuarios();
        }

        public Usuario mostrarUsuario(string nomUsu)
        {
            return this.CDUsuario.mostrarUsuario(nomUsu);
        }

        public void eliminarUsuario(string nomUsu)
        {
            this.CDUsuario.eliminarUsuario(nomUsu);
        }

        public bool actualizarNombreUsuario(string nomUsu, Usuario usu)
        {
            return this.CDUsuario.actualizarNombreUsuario(nomUsu, usu);
        }

        public void actualizarNombre(string nomUsu, Usuario usu)
        {
            this.CDUsuario.actualizarNombre(nomUsu, usu);
        }

        public void actualizarApellido(string nomUsu, Usuario usu)
        {
            this.CDUsuario.actualizarApellido(nomUsu, usu);
        }

        public void actualizarClave(string nomUsu, Usuario usu)
        {
            this.CDUsuario.actualizarClave(nomUsu, usu);
        }

        public void actualizarEmail(string nomUsu, Usuario usu)
        {
            this.CDUsuario.actualizarEmail(nomUsu, usu);
        }

        public bool actualizarEstado(string nomUsu)
        {
           return this.CDUsuario.actualizarEstado(nomUsu);
        }

        public Usuario buscarUsuario(string nomUsu)
        {
            return this.CDUsuario.buscarUsuario(nomUsu);
        }

    }
}
