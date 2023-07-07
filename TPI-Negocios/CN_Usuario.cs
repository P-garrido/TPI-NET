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

        CD_Usuario usuario = new CD_Usuario();

        public void agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email)
        {
            this.usuario.agregarUsuario(nomUsu, clave, nombre, apellido, email);
        }

        public void mostrarUsuarios()
        {
            this.usuario.mostrarUsuarios();
        }

        public void mostrarUsuario(string nomUsu)
        {
            this.usuario.mostrarUsuario(nomUsu);
        }

        public void eliminarUsuario(string nomUsu)
        {
            this.usuario.eliminarUsuario(nomUsu);
        }

        public void actualizarNombreUsuario(string nomUsu)
        {
            this.usuario.actualizarNombreUsuario(nomUsu);
        }

        public void actualizarNombre(string nomUsu)
        {
            this.usuario.actualizarNombreUsuario(nomUsu);
        }

        public void actualizarApellido(string nomUsu)
        {
            this.usuario.actualizarApellido(nomUsu);
        }

        public void actualizarClave(string nomUsu)
        {
            this.usuario.actualizarClave(nomUsu);
        }

        public void actualizarEmail(string nomUsu)
        {
            this.usuario.actualizarEmail(nomUsu);
        }

        public void actualizarEstado(string nomUsu)
        {
            this.usuario.actualizarEstado(nomUsu);
        }
    }
}
