using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_Entidades;

namespace TPI_Datos
{
    public class CD_Usuario
    {

        public CD_Usuario() { }

        CD_Conexion conexion = new CD_Conexion();

        private Usuario buscarUsuario(string nomUsu)
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

        public void agregarUsuario(string nomUsu, string clave, string nombre, string apellido, string email)
        {
            Usuario usu = new Usuario(nomUsu, clave, nombre, apellido, email);
            this.conexion.usuarios.Add(usu);
        }

        public void mostrarUsuarios()
        {
            foreach (Usuario usuario in this.conexion.usuarios)
            {
                Console.WriteLine(usuario.NombreUsuario);
            }
        }

        public void mostrarUsuario(string nomUsu)
        {

            Usuario usu = buscarUsuario(nomUsu);
            Console.WriteLine(usu.Nombre);
            Console.WriteLine(usu.Apellido);
            Console.WriteLine(usu.Email);
        }

        public void eliminarUsuario(string nomUsu)
        {
            Usuario usu = buscarUsuario(nomUsu);
            this.conexion.usuarios.Remove(usu);
        }

        public void actualizarNombreUsuario(string nomUsu)
        {
            bool existe;
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            do
            {
                existe = false;
                Console.WriteLine("Ingrese el nombre de usuario nuevo");
                string aux = Console.ReadLine();
                foreach (Usuario usuario in this.conexion.usuarios)
                {
                    if (usuario.NombreUsuario == aux)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    usuarioACambiar.NombreUsuario = aux;
                }
                else
                {
                    Console.WriteLine("Ya existe este nombre de usuario");
                }
            } while (existe);
        }

        public void actualizarNombre(string nomUsu)
        {
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            Console.WriteLine("Ingrese el nombre nuevo");
            string aux = Console.ReadLine();
            usuarioACambiar.Nombre = aux;

        }

        public void actualizarApellido(string nomUsu)
        {
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            Console.WriteLine("Ingrese el apellido nuevo");
            string aux = Console.ReadLine();
            usuarioACambiar.Apellido = aux;

        }

        public void actualizarClave(string nomUsu)
        {
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            Console.WriteLine("Ingrese la clave nueva");
            string aux = Console.ReadLine();
            usuarioACambiar.Clave = aux;

        }

        public void actualizarEmail(string nomUsu)
        {
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            Console.WriteLine("Ingrese el email nuevo");
            string aux = Console.ReadLine();
            usuarioACambiar.Email = aux;

        }

        public void actualizarEstado(string nomUsu)
        {
            Usuario usuarioACambiar = buscarUsuario(nomUsu);
            usuarioACambiar.Habilitado = !usuarioACambiar.Habilitado;

            switch (usuarioACambiar.Habilitado)
            {
                case true:
                    Console.WriteLine("El estado del usuario es habilitado");
                    break;
                case false:
                    Console.WriteLine("El estado del usuario es deshabilitado");
                    break;
            }
        }


    }
}
