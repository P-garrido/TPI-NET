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

        public void agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email)
        {
            this.CDUsuario.agregarUsuario(nomUsu, clave, nombre, apellido, email);
        }

        public List<Usuario> mostrarUsuarios()
        {
            return this.CDUsuario.mostrarUsuarios();
        }

        public void mostrarUsuario(string nomUsu)
        {
            this.CDUsuario.mostrarUsuario(nomUsu);
        }

        public void eliminarUsuario(string nomUsu)
        {
            this.CDUsuario.eliminarUsuario(nomUsu);
        }

        public void actualizarNombreUsuario(string nomUsu)
        {
            this.CDUsuario.actualizarNombreUsuario(nomUsu);
        }

        public void actualizarNombre(string nomUsu)
        {
            this.CDUsuario.actualizarNombreUsuario(nomUsu);
        }

        public void actualizarApellido(string nomUsu)
        {
            this.CDUsuario.actualizarApellido(nomUsu);
        }

        public void actualizarClave(string nomUsu)
        {
            this.CDUsuario.actualizarClave(nomUsu);
        }

        public void actualizarEmail(string nomUsu)
        {
            this.CDUsuario.actualizarEmail(nomUsu);
        }

        public void actualizarEstado(string nomUsu)
        {
            this.CDUsuario.actualizarEstado(nomUsu);
        }

        public void inicializar()
        {
            this.CDUsuario.agregarUsuario("PedroG", "pedro123", "Pedro", "Garrido", "Pedro@gmail.com");
        }
    }
}
