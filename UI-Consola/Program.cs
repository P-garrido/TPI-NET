
using System.Runtime.CompilerServices;
using TPI_Negocios;
using TPI_Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        CN_Usuario CNUsuario = new CN_Usuario();
        //CNUsuario.inicializar();
        

        int opc;
        string nomUsu, cla, nom, ap, mail;

        do
        {
            Console.WriteLine("Elige una opción");
            Console.WriteLine("1-Agregar usuario 2-Editar usuario 3-Mostrar usuario 4-Eliminar usuario, 5-Mostrar todos los usuarios 0-Salir");
            opc = int.Parse(Console.ReadLine());
            switch(opc)
            {
                case 0:
                    Console.WriteLine("Saliste de la aplicación");
                    break;
                case 1:
                    //Agregr Usuario
                    bool existe= false;
                    do
                    {
                        if (existe)
                        {
                            Console.WriteLine("El nombre de usuario ya existe");
                        }
                        Console.WriteLine("Ingrese nombre de usuario");
                        nomUsu = Console.ReadLine();
                        Console.WriteLine("Ingrese clave");
                        cla = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre");
                        nom = Console.ReadLine();
                        Console.WriteLine("Ingrese apellido");
                        ap = Console.ReadLine();
                        Console.WriteLine("Ingrese email");
                        mail = Console.ReadLine();
                        existe =CNUsuario.agregarUsuario(nomUsu, cla, nom, ap, mail);
                    }while (existe);
                   
                    break;
                case 2:
                    //Editar datos Usuario
                    int opcEdit;
                    string aux;
                    Usuario usuarioACambiar;
                    do
                    {
                        Console.WriteLine("Ingrese opción para editar");
                        Console.WriteLine("1-Nombre de usuario 2-Nombre 3-Apellido 4-Clave 5-Email 6-Estado 0-Salir");
                        opcEdit = int.Parse(Console.ReadLine());
                        switch (opcEdit)
                        {
                            case 0:
                                Console.WriteLine("Saliste de editar");
                                break;
                            case 1:
                                //Editar nombre de usuario
                                string nomNuevo;
                                bool existeUsu= false;
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();

                                Usuario usu = CNUsuario.buscarUsuario(aux);
                                if (usu == null)
                                {
                                    Console.WriteLine("Usuario no existe");
                                }
                                else
                                {
                                    do
                                    {
                                        if (existeUsu)
                                        {
                                            Console.WriteLine("El nombre de usuario ya existe");
                                        }
                                        Console.WriteLine("Ingrese el nombre de usuario nuevo");
                                        nomNuevo = Console.ReadLine();
                                        existeUsu = CNUsuario.actualizarNombreUsuario(nomNuevo, usu);

                                    }while(existeUsu);
                                    
                                }
                                
                                break;
                            case 2:
                                //Editar Nombre
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();

                                usuarioACambiar = CNUsuario.buscarUsuario(aux);
                                Console.WriteLine("Ingrese el nombre nuevo");
                                nomNuevo = Console.ReadLine();

                                CNUsuario.actualizarNombre(nomNuevo, usuarioACambiar);
                                break;
                            case 3:
                                //Editar Apellido
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                nomUsu = Console.ReadLine();

                                usuarioACambiar = CNUsuario.buscarUsuario(nomUsu);
                                Console.WriteLine("Ingrese el apellido nuevo");
                                aux = Console.ReadLine();

                                CNUsuario.actualizarApellido(aux, usuarioACambiar);
                                break;
                            case 4:
                                //Editar Clave
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                nomUsu = Console.ReadLine();
                                usuarioACambiar = CNUsuario.buscarUsuario(nomUsu);
                                Console.WriteLine("Ingrese la clave nueva");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarClave(aux, usuarioACambiar);
                                break;
                            case 5:
                                //Editar Email
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                nomUsu = Console.ReadLine();
                                usuarioACambiar = CNUsuario.buscarUsuario(nomUsu);
                                Console.WriteLine("Ingrese el email nuevo");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarEmail(aux, usuarioACambiar);
                                break;
                            case 6:
                                //Habilitar o Deshabilitar
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                bool bandera = CNUsuario.actualizarEstado(aux);
                                if (bandera)
                                {
                                    Console.WriteLine("El usuario ha sido habilitado correctamente");
                                }
                                else
                                {
                                    Console.WriteLine("El usuario ha sido deshabilitado correctamente");
                                }
                                break;

                        }
                    }while(opcEdit!=0);
                    break;

                case 3:
                    //Mostrar un usuario
                    Console.WriteLine("Ingrese el nombre de usuario");
                    nomUsu = Console.ReadLine();
                    Usuario usuario = CNUsuario.mostrarUsuario(nomUsu);
                    Console.WriteLine(usuario.NombreUsuario);
                    Console.WriteLine(usuario.Nombre);
                    Console.WriteLine(usuario.Apellido);
                    Console.WriteLine(usuario.Email);
                    break;
                case 4:
                    //Eliminar un usuario
                    Console.WriteLine("Ingrese el nombre de usuario");
                    nomUsu = Console.ReadLine();
                    CNUsuario.eliminarUsuario(nomUsu);
                    break; 
                case 5:
                    //Mostrar todos los usuarios
                    List<Usuario> usus =  CNUsuario.mostrarUsuarios();
                    foreach(Usuario usu in usus)
                    {
                        Console.WriteLine(usu.NombreUsuario);
                        Console.WriteLine(usu.Nombre);
                        Console.WriteLine(usu.Apellido);
                        Console.WriteLine(usu.Email);
                    }
                    break; 


            }
        }while(opc!=0);

    }
}