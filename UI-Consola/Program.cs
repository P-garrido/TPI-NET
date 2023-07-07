
using TPI_Negocios;

internal class Program
{
    private static void Main(string[] args)
    {
        CN_Usuario usuario = new CN_Usuario();
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Ingrese nombre de usuario");
            string nomUsu = Console.ReadLine();
            Console.WriteLine("Ingrese clave");
            string cla = Console.ReadLine();
            Console.WriteLine("Ingrese nombre");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            string ap = Console.ReadLine();
            Console.WriteLine("Ingrese email");
            string mail = Console.ReadLine();
            usuario.agregarUsuario(nomUsu, cla, nom, ap, mail);
        }
        usuario.mostrarUsuarios();

        Console.WriteLine("Ingrese el nombre de usuario del usuario a actualizar");
        string aux = Console.ReadLine();
        usuario.actualizarNombreUsuario(aux);

        Console.WriteLine("Ingrese el nombre de usuario del usuario a deshabilitar");
        aux = Console.ReadLine();
        usuario.actualizarEstado(aux);



        usuario.mostrarUsuarios();

    }
}