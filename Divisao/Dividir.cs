using System;

namespace Divisao
{
    class Dividir
    {
        static void Main(string[] args)
        {
            int num1;
            //int num2; **Comentei pois declarei a VAR no While true

            Console.WriteLine("Calcladora de Divisão: ");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            Console.WriteLine("Digite o valor da Variavel num1 e pressione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            //** Mudei a inserssao do NUM2 no metodo While true

            //Console.WriteLine("Digite o valor da Variavel num2 e pressione enter");
            //num2 = Convert.ToInt32(Console.ReadLine());


            //Como havia feito antes

            /*if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir um numero por ZERO");
                Console.WriteLine("Por favor digite um numero diferente de ZERO: ");                             
            }
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resultado da divisão é: " + (num1 / num2));*/

            while (true)
            {
                Console.WriteLine("Digite o valor da variavel num2 e pressione ENTER: ");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Po brother, não é possivel dividir um numero por ZERO!!");
                }
                else
                {
                    int divisao = num1 / num2;
                    int restoDaDivisao = num1 % num2;
                    Console.WriteLine($"O resultado da divisao entre {num1} e {num2} é {divisao}, e o resto é {restoDaDivisao}");
                    break;
                }
            }
            Console.WriteLine("\nAperte ENTER para SAIR.");

            Console.ReadLine();
        }
    }
}
