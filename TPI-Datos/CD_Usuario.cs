using System;
using System.Collections.Generic;
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

        CD_Conexion conexion = new CD_Conexion();

        public Usuario buscarUsuario(string nomUsu)
        {
            //var usuario = (Usuario)(from Usuario u in this.usuarios where u.NombreUsuario == nomUsu select u);
            //Console.WriteLine(usuario.Nombre, usuario.Apellido, usuario.Email);
            Usuario usuarioACambiar = null;
            foreach (Usuario usuario in this.conexion.usuarios)
            {
                if (usuario.NombreUsuario == nomUsu)
                {
                    usuarioACambiar = usuario;
                    break;
                }
            }
            return usuarioACambiar;
        }

        public bool agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email)
        {
            foreach (Usuario usuario in this.conexion.usuarios)
            {
                if (usuario.NombreUsuario == nomUsu)
                {
                    return true;
                }
            }

            Usuario usu = new Usuario(nomUsu, clave, nombre, apellido, email);
            this.conexion.usuarios.Add(usu);
            return false;
        }

        public List<Usuario> mostrarUsuarios()
        {
            List<Usuario> usus = new List<Usuario>();
            foreach (Usuario usuario in this.conexion.usuarios)
            {
                usus.Add(usuario);
            }
            return usus;
        }

        public Usuario mostrarUsuario(string nomUsu)
        {

            Usuario usu = buscarUsuario(nomUsu);
            return usu;
        
        }

        public void eliminarUsuario(string nomUsu)
        {
            Usuario usu = buscarUsuario(nomUsu);
            this.conexion.usuarios.Remove(usu);
        }

        public bool actualizarNombreUsuario(string nomUsu, Usuario usu)
        {
            foreach (Usuario usuario in this.conexion.usuarios)
            {
                if (usuario.NombreUsuario == nomUsu)
                {
                    return true;
                }
            }
            
            usu.NombreUsuario = nomUsu;
            return false;
        }

        public void actualizarNombre(string nomUsu, Usuario usu)
        {
       
            usu.Nombre = nomUsu;

        }

        public void actualizarApellido(string nomUsu, Usuario usu)
        {
           
            usu.Apellido = nomUsu;

        }

        public void actualizarClave(string nomUsu, Usuario usu)
        {
            usu.Clave = nomUsu;

        }

        public void actualizarEmail(string nomUsu, Usuario usu)
        {
            usu.Email = nomUsu;

        }

        public bool actualizarEstado(string nomUsu)
        {
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            usuarioACambiar.Habilitado = !usuarioACambiar.Habilitado;

            switch (usuarioACambiar.Habilitado)
            {
                case true:
                    return true;
                case false:
                    return false;
            }
        }


    }
}
