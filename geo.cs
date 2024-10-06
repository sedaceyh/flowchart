using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int c = 0;
        double p = 1.0;
        Console.WriteLine("Sayı Adeti Girin: ");
        int count = Convert.ToInt32(Console.ReadLine());

        while (c < count)
        {
            Console.WriteLine("Gerçek Sayı Girin: ");
            double x = Convert.ToDouble(Console.ReadLine());
            c = c + 1;
            p = p * x;
        }

        double gm = Math.Pow(p, 1.0 / count);
        Console.WriteLine("Ortalama: " + gm);
    }
}

