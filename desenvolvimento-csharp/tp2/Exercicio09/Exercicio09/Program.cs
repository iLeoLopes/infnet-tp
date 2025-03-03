using System.Globalization;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioLiquido = salarioBruto;
            double imposto;
            double descontado;

            if (salarioBruto >= 4664)
            {
                imposto = 0.275;
                salarioLiquido -= (salarioBruto * imposto);
                descontado = salarioBruto * imposto;
            }
            else if (salarioBruto >= 3752)
            {
                imposto = 0.225;
                salarioLiquido -= (salarioBruto * imposto);
                descontado = salarioBruto * imposto;

            }
            else if (salarioBruto >= 2827)
            {
                imposto = 0.15;
                salarioLiquido -= (salarioBruto * imposto);
                descontado = salarioBruto * imposto;

            }
            else if (salarioBruto >= 2259)
            {
                imposto = 0.075;
                salarioLiquido -= (salarioBruto * imposto);
                descontado = salarioBruto * imposto;
            }
            else
            {
                imposto = 0.0;
                salarioLiquido -= imposto;
                descontado = salarioBruto * imposto;
            }
            Console.WriteLine($"\nSalarioBruto: R$ {salarioBruto.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\nTotal descontado: R$ {descontado.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\nSalário Liquido: R$ {salarioLiquido.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}