using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class exercício02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algum número");
            int num;

            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Caractere Invalido");
            }
            else {
                int i = 0;
                Console.WriteLine($"Tabuada até o 10 do número {num} ");

                while (i <= 10)
                {
                    var soma = num * i;
                    Console.WriteLine($"{i}x{num}={soma}");
                    i++;
                }
            }
        }
    }
}
