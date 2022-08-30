namespace Hausaufgabe
{
    internal class MyMath
    {
        static void Main(string[] args)
        {
            double a, b, c, d, z, kgv;
            int answ;

            d = 0;

            do
            {
                Console.WriteLine("Bitte geben Sie die erste Zahl ein: ");
                a = Convert.ToDouble(Console.ReadLine());
                c = a;

                Console.WriteLine("Bitte geben Sie den zweiten Wert ein: ");
                b = Convert.ToDouble(Console.ReadLine());
                d = b;

                while (b != 0)
                {
                    z = a % b;
                    a = b;
                    b = z;
                }

                kgv = (c * d) / a;

                Console.WriteLine($"der ggT von {c} und {d} ist {a}");
                Console.WriteLine($"der kgV von {c} und {d} ist {kgv}");
                Console.WriteLine("Möchten Sie einen weiteren ggT berechnen? (1 = ja, 0 = nein)");
                answ = Convert.ToInt32(Console.ReadLine());
            }
            while (answ != 0);
        }
    }
}
