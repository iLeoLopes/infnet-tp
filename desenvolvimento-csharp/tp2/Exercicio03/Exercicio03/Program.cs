namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime();
            DateTime data2 = new DateTime();
            Console.Write("Data de início: ");
            data1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de fim: ");
            data2 = DateTime.Parse(Console.ReadLine());

            int meses = 0;
            int anos = 0;
            TimeSpan dias = new();

            while(data1.AddYears(1) <= data2)
            {
                data1 = data1.AddYears(1);
                anos++;
            }
            
            while(data1.AddMonths(1) <= data2)
            {
                data1 = data1.AddMonths(1);
                meses++;
            }
            dias = data2.Subtract(data1);
            Console.WriteLine($"{anos} ano(s), {meses} mes(es) e {dias.Days} dia(s).");
        }

    }
}
