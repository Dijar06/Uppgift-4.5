using System;

namespace Uppgift4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();

            int svar = 0;
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                if (siffra == 9)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write(siffra + 1);
                }
            }
        }
    }
}