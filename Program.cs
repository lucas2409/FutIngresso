using Microsoft.VisualBasic;
using System;

namespace FutIngressos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario(1, 1, 1, "Lucas", "lucas.garcia2409@gmail.com", "123", "123");
            Jogos j = new Jogos();
            DateTime d = new DateTime(2020, 08, 07);
            j = new Jogos(1, 1, 1000, 1999, 10.00, 50.00, d , "Jogo", "Arena", "Corinthians", "Sao Paulo");
            Console.WriteLine(u);
            Console.WriteLine();
            Console.WriteLine(j);
            Console.WriteLine();

            d = new DateTime(2020, 09, 06);

            string conf = u.AlterarDados(1, 1, 2, "Andre", "andre@yahoo.com", "123", "123L");
            string conf1 = j.AlterarDados(1, 1, 1000, 1999, 10.00, 50.00, d, "Jogo", "Morumbi", "São Paulo", "Corinthians");

            Console.WriteLine(conf);
            Console.WriteLine();
            Console.WriteLine(u);
            Console.WriteLine();
            Console.WriteLine(j);
            Console.WriteLine();

        }
    }
}
