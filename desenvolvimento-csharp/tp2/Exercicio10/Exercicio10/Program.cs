namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para iniciar a contagem regressiva: ");
            int numero = int.Parse(Console.ReadLine());

            while(numero > 0)
            {
                Console.Write($"{numero}, ");
                numero--;
            }
            Console.WriteLine(0);
        }
    }
}
