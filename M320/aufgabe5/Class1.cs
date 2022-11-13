using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    internal class Person
    {
        public static void Main (string[] args){
            int eingabe;
            int wutLevel = Aufgabe5.Emotionen.wutLevel;

            Console.WriteLine("Was ist passiert: \n1) Lohnerhoehung\n2) Frau hat dich betrogen\n 3) Ferien\n4) Schlafen\n 5) Aufwachen(gewollt oder ungewollt)");
            eingabe = Convert.ToInt32(Console.ReadLine());

            Aufgabe5.Emotionen;

            Console.WriteLine("Die neuen Level betragen:\nWut: " + wutLevel);

        }

    }
}
