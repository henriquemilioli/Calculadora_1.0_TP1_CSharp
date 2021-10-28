using System;

namespace Multiplicacao
{
    class Multiplicar
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;            

            Console.WriteLine("Calcladora de Multiplicação: ");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            Console.WriteLine("Digite o valor da Variavel num1 e pressione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da Variavel num2 e pressione enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            int resMultiplicacao = num1 * num2;

            Console.WriteLine("O resultado da multiplicação é: " + resMultiplicacao);

            Console.WriteLine("\nAperte ENTER para SAIR.");

            Console.ReadLine();
        }
    }
}
