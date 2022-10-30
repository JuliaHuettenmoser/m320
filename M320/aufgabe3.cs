namespace test
{
    internal class calculator
    {
        static void Main(string[] args)

        {
            int zahla;
            int zahlb;
            int ergebnis;
            String eingabe;


            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            zahla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            zahlb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie den Operator ein: ");
            eingabe = Convert.ToString(Console.ReadLine());

            if(eingabe == "+")
            {
                ergebnis = zahla + zahlb;

                Console.WriteLine("Das Ergbenis ist: " + ergebnis);
            }

            else if (eingabe == "-")
            {
                ergebnis = zahla - zahlb;

                Console.WriteLine("Das Ergbenis ist: " + ergebnis);
            }

            else if (eingabe == "*")
            {


                Console.WriteLine("Das Ergbenis ist: " + zahla * zahlb);
            }

            else if (eingabe == "/")
            {

                Console.WriteLine("Das Ergbenis ist: " + zahla / zahlb);
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}
