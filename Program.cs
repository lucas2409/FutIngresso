using System;

namespace FutIngressos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario(1, 1, 1, "Lucas", "lucas.garcia2409@gmail.com", "123", "123");

            Console.WriteLine(u);
            Console.WriteLine();

            string conf = u.AlterarDados(1, 1, 2, "Andre", "andre@yahoo.com", "123", "123L");

            Console.WriteLine(conf);
            Console.WriteLine();
            Console.WriteLine(u);
            
        }
    }
}
