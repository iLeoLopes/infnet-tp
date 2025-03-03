using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Data de nascimento dd/mm/yyyy: ");
        try
        {
            string dataNascimento = Console.ReadLine();
            DateTime dataFormatada = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", null);
            DateTime hoje = DateTime.Now;
            DateTime aniversarioEsteAno = new DateTime(hoje.Year, dataFormatada.Month, dataFormatada.Day);

            if (aniversarioEsteAno < hoje)
            {
                aniversarioEsteAno = new DateTime(hoje.Year + 1, dataFormatada.Month, dataFormatada.Day);
            }
            int diasRestantes = (aniversarioEsteAno - hoje).Days + 1;
            Console.WriteLine($"Faltam {diasRestantes} dias para o seu aniversário!");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Data inválida.\n{ex.Message}");
        }
    }
}
