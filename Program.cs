namespace Project_Euler_Problem_2
{
    class Program
    {
        static void Main()
        {
            long f1 = 1, f2 = 1, f3 = 0, toplam = 0;

            while (f3 < 4000000)
            { 
                if (f3 % 2 == 0)
                    toplam = toplam + f3
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            System.Console.Write("4 Milyona Kadar çift fibonacci sayıların toplamı : " + toplam);
            System.Console.WriteLine();
        }
    }
}
