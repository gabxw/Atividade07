
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class exercicio11
    {
        static void Main(string[] args)
        {

            int[] num = new int[4];
            Console.Write("Digite um número inteiro: ");
            if (!int.TryParse(Console.ReadLine(), out num[0])){
                Console.WriteLine("Caractere inválido");
            }else{
                if (num.All(x => x >= 0)){
                    int i = 0;
                    while(i < 4){
                        Console.Write("Digite um número inteiro: ");
                        num[i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }
                    int soma = 0;
                    i = 0;
                    do{
                        soma += num[i];
                        i++;
                    }
                    while(i < 4);
                    Console.Write($"A soma dos números digitados: {soma}");
                }else{
                    Console.WriteLine("Número negativo");
                    Environment.Exit(0);
                }
            }
        }
    }
}
