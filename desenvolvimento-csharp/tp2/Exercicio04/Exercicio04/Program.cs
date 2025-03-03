namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu telefone: ");
            string telefone =Console.ReadLine();

            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine($"\nUsuário: \n{nome}, {idade} anos.\nEmail: {email} \nTelefone: {telefone}");
        }
    }
}
