using System;
using Figgle;

namespace ObrigadoDevCsHarp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Big.Render("Obrigado,"));
            Console.WriteLine(FiggleFonts.Crazy.Render("Dev C# !"));
            Console.Write("Presione uma tecla para finalizar...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
