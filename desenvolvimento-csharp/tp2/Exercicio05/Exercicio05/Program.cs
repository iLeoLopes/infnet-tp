using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor em graus Celsius para conversão: ");
            double celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double fharenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine(
                $"Fahrenheit: {fharenheit.ToString("F2", CultureInfo.InvariantCulture)}°F" +
                $"\nKelvin: {kelvin.ToString("F2", CultureInfo.InvariantCulture)} K");
        }
    }
}