using System;

namespace Tema5Ex4
{
    class Program
    {
        //Ex 4
        //Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
        //de la tastatura, ignorand caseing-ul literelor.

        static char aparitii(string a)
        {
            int[] count = new int[256];
            int max = 0;
            Char rezultat = Char.MinValue;

            Array.Clear(count, 0, count.Length - 1);

            foreach (Char c in a)
            
                if (c != ' ' && ++count[c] > max)
                {
                    max = count[c];
                    rezultat = c;
                }

            return rezultat;
           

        }


        static void Main(string[] args)
        
        
        
        {
            Console.WriteLine("Introduceti stringul!");
            string cuvant = Console.ReadLine();

            Console.WriteLine("Caracterul care apare cel mai mult este " + aparitii(cuvant));


        }
    }
}
