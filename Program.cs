using System;
using System.Collections.Generic;

namespace Puzzles
{
    class puzzles
    {
        public static void RandomArray()
        // RANDOM ARRAY CHALLENGE IN PUZZLES
        {
            int[] randomArray = new int[10];
            Random rand = new Random();
            for(int val = 0; val < 10; val++)
            {
                int add = rand.Next(5,25);
                randomArray[val]=add;
            }
            // DISPLAY ARRAY
            Console.Write("Elements In Array Are: ");
            for(int val = 0; val < 10; val++)
            {
                Console.Write("{0} ", randomArray[val]);
            }
            Console.WriteLine(); // blank line return 

            // DISPLAY MAX VALUE OF ARRAY
            Console.Write("The Max Value in he Array is: ");
            int max = randomArray[0];
            foreach (var maxNum in randomArray)
            {
                if (maxNum > max)
                {
                    max = maxNum;
                }
            }
            Console.Write(max);
            Console.WriteLine(); // blank line return

            //DISPLAY MIN VALUE OF ARRAY 
            Console.Write("The Min Value in he Array is: ");
            int min = randomArray[0];
            foreach (var minNum in randomArray)
            {
                if (minNum < min)
                {
                    min = minNum;
                }
            }
            Console.Write(min);
            Console.WriteLine(); // blank line return
        }

        public static string CoinFlip()
        // SIMULATE TOSSING A COIN
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            //THE COIN FLIP
            int coin = rand.Next(1,3);
            if (coin == 1)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        public static void TossMultipleCoins(int num)
        // CALCULATE SEVERAL ITERATIONS OF COIN TOSS, DISPLAY RATIO
        {
            int flip = 0;
            int heads = 0;
            while (flip <= num)
            {
                CoinFlip();
                if (CoinFlip() == "Heads")
                {
                    heads+=1;
                }
                flip += 1;
            }
            Console.WriteLine($"The Ratio of Heads Tossed to Total Tosses is {heads}:{flip}");
        }

        public static string[] Names()
        {
            string[] Names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random ();
            for (int i = 0; i < Names.Length; i++)
            {
                int j = rand.Next(Names.Length);
                string temp = Names[j];
                Names[j] = Names[i];
                Names[i] = temp;
            }

        
            Console.Write("Names In Rearranged List Are: ");
            for(int i = 0; i < Names.Length; i++)
            {
                Console.Write("{0} ", Names[i]);
            }
            Console.WriteLine();
            Console.Write("Names w/ greater than five letters: ");
            foreach (var name in Names)
            {
                if (name.Length >=5)
                {
                    Console.Write($"{name}, ");
                }
            }
            return Names;
            
        }
        
        
        
        
        static void Main(string[] args)
        {
            puzzles.RandomArray();
            puzzles.CoinFlip();
            puzzles.TossMultipleCoins(15);
            puzzles.Names();
        }
    }
}
