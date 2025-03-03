using System.Globalization;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota < 7.0)
            {
                Console.WriteLine("Nota insuficiente.");
            }
            else if (nota < 8.0)
            {
                Console.WriteLine("Nota Regular.");
            }
            else if (nota < 9.0)
            {
                Console.WriteLine("Nota boa!");
            }
            else
            {
                Console.WriteLine("Nota EXCELENTE!!");
            }
        }
    }
}