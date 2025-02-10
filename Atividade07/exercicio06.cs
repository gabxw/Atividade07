using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class exercicio06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");

            int num;

            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Caractere inválido");
            }
            else
            {
                if (num > 0)
                {
                    int i = 0;
                    Console.WriteLine("Os números pares de 0 até o número escolhido:");
                    while (i <= num){
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                        i++;
                    }
                }
            }
        }
    }
}
