namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual número estou pensando? ");
            int tentativaDoUsuario = int.Parse(Console.ReadLine());
            Random numeroAleatorio = new Random();
            int numeroPensado = numeroAleatorio.Next(1, 100);
            while (tentativaDoUsuario != numeroPensado)
            {
                if (tentativaDoUsuario < numeroPensado)
                {
                    Console.Write("Errado! Seu palpite é menor!! \n\nQual número estou pensando? ");
                    tentativaDoUsuario = int.Parse(Console.ReadLine());
                }
                else if (tentativaDoUsuario > numeroPensado)
                {
                    Console.Write("Errado! Seu palpite é maior!! \n\nQual número estou pensando? ");
                    tentativaDoUsuario = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"\nAcertou!! O número que pensei foi: {numeroPensado}");
        }
    }
}