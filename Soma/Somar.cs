using System;

namespace Soma
{
    class Somar
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            //TESTE COMMIT
            Console.WriteLine("Calculadora de soma");
            Console.WriteLine("+++++++++++++++++++");
            //TESTE COMMIT 2.0
            Console.WriteLine("Digite o valor da Variavel num1 e pressione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da Variavel num2 e pressione enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O resultado da soma é: " + (num1 + num2));

            Console.WriteLine("\nAperte ENTER para SAIR.");

            Console.ReadLine(); 
        }
    }
}
