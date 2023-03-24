//EXERCICIO-03/ Faça um progama que: 
// - Leia a cotação do dolar
// - Leia um valor em dolares
// - Converta esse valor para Real
// - Mostre o resultado 
using System;
namespace Exercicio_03

{
    class progam
    {
        public static void Main(String[] argos)
        {
            double cotacaoDolar;
            double cotacaoReal;
            double quantDolar;
            double quantReal;
            double valorDolar;
            double valorReal;

            Conversor conversor = new Conversor();

            string opcaoUsuario = obterOpcaoUsuario();
            while (opcaoUsuario != "3")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Cotação atual do Dolar (em relação ao Real) : ");
                        cotacaoDolar = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual valor em dolares deseja converter : ");
                        quantDolar = double.Parse(Console.ReadLine());
                        valorReal = conversor.ConverterDolar(cotacaoDolar, quantDolar);
                        Console.WriteLine($"Valor em Real : R${valorReal}");
                        break;

                    case "2":
                        Console.WriteLine("Cotação atual do Real (em relação ao Dolar) : ");
                        cotacaoReal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual valor em Reais deseja Converter : ");
                        quantReal = double.Parse(Console.ReadLine());
                        valorDolar = conversor.ConverterDolar(cotacaoReal, quantReal);
                        Console.WriteLine($"Valor em dolares : U${valorDolar}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Opção invalida!");
                }
                opcaoUsuario = obterOpcaoUsuario();
            }







            string obterOpcaoUsuario()
            {
                Console.WriteLine("========================");
                Console.WriteLine("CONVERSOR DE MOEDA");
                Console.WriteLine("========================");
                Console.WriteLine("Escolha uma opção :");
                Console.WriteLine("1 - Converter Dolar para Real");
                Console.WriteLine("2 - Converter Real para Dolar");
                Console.WriteLine("3 - Sair");

                string obterOpcao = Console.ReadLine();
                return obterOpcao;
            }


        }
    }
}
