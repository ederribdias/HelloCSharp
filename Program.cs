using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nComo você se chama?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nOlá, {name}, hoje é dia {date:d} e são {date:t}!");
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}
