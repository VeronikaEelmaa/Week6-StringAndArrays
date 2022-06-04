using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            string hellow = "Hello World!";
                                                                           
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == 'h')
                {
                    hCounter++;
                }
                else if(hellow[i] == 'o')
                {
                    oCounter++;
                }
                else if(hellow[i] == 'l')
                {
                    lCounter++;
                }

            }


            if (hCounter != 1)
            {
                Console.WriteLine($"Hello World! sisaldab {hCounter} 'h' tähte.");
            }


            if (oCounter != 1)
            {
                Console.WriteLine($"Hello World! sisaldab {oCounter} 'o' tähte.");
            }


            if (lCounter != 1) 
            {
                Console.WriteLine($"Hello World! sisaldab {lCounter} 'l' tähte.");
            }

        }
    }
}
