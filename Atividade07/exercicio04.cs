
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class exercicio04
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a sua senha: ");
            string senha = Console.ReadLine();
            if (senha == "1234"){
                Console.WriteLine("Acesso Permitido");
                Console.delay(2000);
                Console.Clear();
                Console.WriteLine("======Area de acesso======");
            }else{
                int i = 0;
                while(i < 3){
                    Console.WriteLine("Senha incorreta");
                    Console.Write("Digite a sua senha: ");
                    senha = Console.ReadLine();
                    i++;
                }
                Console.WriteLine("Acesso negado");
                Console.delay(2000);
                Environment.Exit(0); 
                
            }
        }
    }
}
