using System; 
namespace Exercicio_02
{
    class Program
    {
        public static void Main(String[] args)
        {
            int QuantidadeMinima;
            int QuantidadeMaxima;
            double EstoqueMedio;
            Media media = new Media(); 

            Console.WriteLine("====================");
            Console.WriteLine("ESTOQUE MÉDIO DE PEÇAS");
            Console.WriteLine("====================");
            Console.WriteLine();
            Console.WriteLine("Quantidade minima: ");
            QuantidadeMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade maxima: ");
            QuantidadeMaxima = int.Parse(Console.ReadLine());
            EstoqueMedio = media.CalcularEstoqueMedio(QuantidadeMinima, QuantidadeMaxima);
            Console.WriteLine($"O estoque médio de peças é de : {EstoqueMedio}");

        }
    }
}