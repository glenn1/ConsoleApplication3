using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] teeBall = new int[12, 5];
            int x = 0;
            int y = 0;
            //int quit = 99;
            int errCount = 0;
            int player = 0;
            int bases = 0;
            string input;

            for (x = 0; x < 11; ++x)
            {

                Console.Write("Enter a player number: ", teeBall[x, y]);
                input = Console.ReadLine();
                player = Convert.ToInt32(input);

                if (player < 0 || player > 11)

                    Console.Write("**Error,{0} is invalid, enter a number between 0 and 11 or 99 to quit: ", player);
                errCount++;

                //input = Console.ReadLine();
                player = Convert.ToInt32(input);

                if (player == 99)
                    break;

                Console.Write("Enter number of bases: ", teeBall[x, y]);
                input = Console.ReadLine();
                bases = Convert.ToInt32(input);


                if (bases < 0 || bases > 4)
                    Console.Write("**Error,{0} is invalid, enter a number between 0 and 4: ", bases);
                errCount++;

                //input = Console.ReadLine();
                bases = Convert.ToInt32(input);




            }

            Console.WriteLine("  Player  |  0 Bases  |  1 Base  |  2 Bases  |  3 Bases  |  4 Bases");
            const int DASHES = 75;
            for (int s = 0; s < DASHES; ++s)
                Console.Write('-');

            Console.WriteLine();

            for (int t = 0; t < 12; t++)
            {
                Console.Write("{1, 10}|", "0", t);
                for (int z = 0; z < 5; z++)
                {
                    Console.Write("{0, 10}", "0", t, z);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("The total number of errors was:{0} ", errCount);
            Console.WriteLine(teeBall[player, bases]++);

            Console.ReadLine();
        }
    }
}
