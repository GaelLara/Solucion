namespace ProyectoConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA C# Y GITHUB");

            string nombre = "Gael";
            Console.WriteLine(nombre);

            string[] nombres = new string[4];
            nombres[0] = "Gael";
            nombres[1] = "Cristo";
            nombres[2] = "Fransisco";
            nombres[3] = "Kevin";
            Console.WriteLine(nombres[3]);

            Console.WriteLine();
            Console.WriteLine("Mostrando todos los elementos del arreglo");
            Console.WriteLine();

            foreach (string nombreAlumno in nombres)
            {
                Console.WriteLine(nombreAlumno);
            }



        }
    }
}
