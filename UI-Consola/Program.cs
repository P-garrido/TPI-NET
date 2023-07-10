
using System.Runtime.CompilerServices;
using TPI_Negocios;

internal class Program
{
    private static void Main(string[] args)
    {
        CN_Usuario CNUsuario = new CN_Usuario();
        CNUsuario.inicializar();
        

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
                    CNUsuario.agregarUsuario(nomUsu, cla, nom, ap, mail);
                    break;
                case 2:
                    int opcEdit;
                    string aux;
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
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarNombreUsuario(aux);
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarNombre(aux);
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarApellido(aux);
                                break;
                            case 4:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarClave(aux);
                                break;
                            case 5:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarEmail(aux);
                                break;
                            case 6:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                CNUsuario.actualizarEstado(aux);
                                break;

                        }
                    }while(opcEdit!=0);
                    break;

                case 3:
                    Console.WriteLine("Ingrese el nombre de usuario");
                    nomUsu = Console.ReadLine();
                    CNUsuario.mostrarUsuario(nomUsu);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre de usuario");
                    nomUsu = Console.ReadLine();
                    CNUsuario.eliminarUsuario(nomUsu);
                    break; 
                case 5:
                    CNUsuario.mostrarUsuarios();
                    break; 


            }
        }while(opc!=0);

    }
}