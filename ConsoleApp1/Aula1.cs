using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aula1
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Olá, {nome}. Qual a sua idade? "); //$ = interpolacao de string
            int idade = 0;
            while (idade == 0)
            {
                try
                {
                    int resultado = 10 / idade;
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dado invalido! Digite novamente");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Erro de divisao por zero");
                }
            }

            Console.WriteLine($"Olá, {nome} sua idade é: {idade}");
            Console.ReadLine();
        }
    }
}
