using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class exercicio03
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int i = 0;
            while (i < 5){
                Console.Write("Digite um número inteiro: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            int soma = 0;
            i = 0;
            while(i < 5){
                soma += num[i];
                i++;
            }
            Console.Write($"A soma dos números digitados: {soma}");
            
            
        }
    }
}
