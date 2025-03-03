using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento dd/mm/yyyy: ");
            string dataNascimento = Console.ReadLine();
            
            try
            {
                DateTime dataFormatada = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", null, DateTimeStyles.None);
                DateTime dataAtual = DateTime.Now;
                
                int anos = dataAtual.Year - dataFormatada.Year;
                int meses = dataAtual.Month - dataFormatada.Month;
                int dias = dataAtual.Day - dataFormatada.Day;

                if (dias < 0)
                {
                    meses--;
                    DateTime mesAnterior = dataAtual.AddMonths(-1);
                    dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month); // ano bissexto
                }

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }
                
                Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Data inválida.\n{ex.Message}");
            }
        }
    }
}


