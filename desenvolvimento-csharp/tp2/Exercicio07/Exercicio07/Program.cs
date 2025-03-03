namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            string resutado = numero % 2 == 0 ? "par" : "ímpar";
            Console.WriteLine($"O número {numero} é {resutado}.");
        }
    }
}
