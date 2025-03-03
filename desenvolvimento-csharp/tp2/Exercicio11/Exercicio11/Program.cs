namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para gerar a tabuada de 1 a 10: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {i * numero}");
            }
        }
    }
}
