
using TPI_Negocios;

internal class Program
{
    private static void Main(string[] args)
    {
        CN_Usuario usuario = new CN_Usuario();
        //for (int i = 0; i < 2; i++)
        //{
        //    Console.WriteLine("Ingrese nombre de usuario");
        //    string nomUsu = Console.ReadLine();
        //    Console.WriteLine("Ingrese clave");
        //    string cla = Console.ReadLine();
        //    Console.WriteLine("Ingrese nombre");
        //    string nom = Console.ReadLine();
        //    Console.WriteLine("Ingrese apellido");
        //    string ap = Console.ReadLine();
        //    Console.WriteLine("Ingrese email");
        //    string mail = Console.ReadLine();
        //    usuario.agregarUsuario(nomUsu, cla, nom, ap, mail);
        //}
        //usuario.mostrarUsuarios();

        //Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
        //string aux = Console.ReadLine();
        //usuario.actualizarNombreUsuario(aux);

        //Console.WriteLine("Ingrese el nombre de usuario del usuario a deshabilitar");
        //aux = Console.ReadLine();
        //usuario.actualizarEstado(aux);



        //usuario.mostrarUsuarios();

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
                    usuario.agregarUsuario(nomUsu, cla, nom, ap, mail);
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
                                usuario.actualizarNombreUsuario(aux);
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                usuario.actualizarNombre(aux);
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                usuario.actualizarApellido(aux);
                                break;
                            case 4:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                usuario.actualizarClave(aux);
                                break;
                            case 5:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                usuario.actualizarEmail(aux);
                                break;
                            case 6:
                                Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
                                aux = Console.ReadLine();
                                usuario.actualizarEstado(aux);
                                break;

                        }
                    }while(opcEdit!=0);
                    break;

                case 3:
                    Console.WriteLine("Ingrese el nombre de usuario");
                    nomUsu = Console.ReadLine();
                    usuario.mostrarUsuario(nomUsu);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre de usuario");
                    nomUsu = Console.ReadLine();
                    usuario.eliminarUsuario(nomUsu);
                    break; 
                case 5:
                    usuario.mostrarUsuarios();
                    break; 


            }
        }while(opc!=0);

    }
}