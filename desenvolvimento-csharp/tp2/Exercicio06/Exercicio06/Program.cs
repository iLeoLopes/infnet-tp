using System.Globalization;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = peso / Math.Pow(altura, 2);

            switch (imc)
            {
                case < 18.5:
                    Console.WriteLine($"\nIMC: {imc.ToString("F2", CultureInfo.InvariantCulture)} \nClassificação: Baixo peso.");
                    break;
                case < 25:
                    Console.WriteLine($"\nIMC: {imc.ToString("F2", CultureInfo.InvariantCulture)} \nClassificação: Normal.");
                    break;
                case < 30:
                    Console.WriteLine($"\nIMC: {imc.ToString("F2", CultureInfo.InvariantCulture)} \nClassificação: Sobrepeso.");

                    break;
                default:
                    Console.WriteLine($"\nIMC: {imc.ToString("F2", CultureInfo.InvariantCulture)} \nClassificação: Obesidade.");
                    break;
            }
        }
    }
}
