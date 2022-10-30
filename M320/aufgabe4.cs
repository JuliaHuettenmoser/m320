using System;

namespace test
{
    internal class claculator
    {
        static void calculate(string[] args)

        {
            useParam(1, 2, 3, 4);
        }

        public static int useParam (params int[] list)
        {
            for(int i  = 0; i < list.Length; i++)
            {
                list[i] += i;
                Console.WriteLine(list[i]);
            }
        }
    }
}
