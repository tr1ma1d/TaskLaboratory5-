using System;


namespace lab5
{
    class FractionReduction
    {
        int n;
        int d;
        public int Numr { get;  }
        public int Denomi { get; }
        public FractionReduction(int numr, int denomi)
        {
            Numr = numr;
            Denomi = denomi; 
        }
        public void MFraction_Reduction()
        {
            n = Numr;
            d = Denomi;

            if (Denomi % Numr == 0 && Denomi > Numr)
            {
                n /= Numr;
                d /= Numr;
                Console.WriteLine($"NewFraction: {n} / {d}");
            }
            else if (Numr % Denomi == 0 && Numr >= Denomi)
            {
                n /= d;
                Console.WriteLine($"Целое число: {n}");
            }
            else
                Console.WriteLine("Нельзя сократить дроб");
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your fraction: {numerator} / {denominator}");
            Console.WriteLine();
            Console.WriteLine($"________________________CODE BY NIKITA MUSATOV ON GITHUB_________________________________");
            Console.WriteLine();
            FractionReduction fr = new FractionReduction(numerator, denominator);
            fr.MFraction_Reduction();


        }
    }
}