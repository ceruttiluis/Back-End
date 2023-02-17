using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgBackend.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto, int repeticao, string simbolo)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write($"{texto}");

            for (var i = 0; i < repeticao; i++)
            {
                Console.Write(simbolo);
                Thread.Sleep(300);
            }
            Console.Write("!");
            Thread.Sleep(300);
            Console.ResetColor();
        }
    }
}