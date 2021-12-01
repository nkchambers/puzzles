using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(10);

            var result = Names();

        }
        
        //-------------------------------------RANDOM ARRAY FUNCTION----------------------------------------
        public static int[] RandomArray() 
        {
            Random rand = new Random();
            int [] numsArray = new int[10];

            for (int i = 0; i < numsArray.Length; i++) 
            {
                numsArray[i] = rand.Next(5, 26);
                Console.WriteLine(numsArray[i]);
            }
            //Find Min, Max and Sum
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int sum = 0;

            foreach (var num in numsArray) 
            {
                if (num > max)
                    max = num;
                
                if (num < min)
                    min = num;
                
                sum += num;
            }

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Sum: {sum}");

            return numsArray;
        }
        //--------------------------------------COIN FLIP FUNCTION---------------------------------------
        public static string TossCoin() 
        {
            
            Random rand = new Random();
            string result;

            Console.WriteLine("Tossing a Coin!");

            if (rand.Next(2) == 0) 
                result = "Heads";
            else 
                result = "Tails";
                

            Console.WriteLine($"Coin Flip: {result}");

            return result;

        }

        //--------------------------------------MULTIPLE COIN FLIP FUNCTION-------------------------------------
        public static double TossMultipleCoins(int numFlips) 
        {
            Random rand = new Random();
            int result = 0;
            string value = "";
            double numHeads = 0, ratio = 0;

            Console.WriteLine($"Tossing {numFlips} Coin(s)!");
            
            for(int toss = 1; toss <= numFlips; toss++)
            {
                result = rand.Next(2);
                if (result == 0) 
                {
                    value = "Heads";
                    Console.WriteLine($"Coin Flip: {value}");
                    numHeads++;
                }
                else 
                {
                    value = "Tails";
                    Console.WriteLine($"Coin Flip: {value}"); 
                }
            }
            ratio = numHeads/numFlips;
            Console.WriteLine($"Heads: {numHeads} / Total Flips: {numFlips}");
            return ratio;
        }
        
        // --------------------------------------LIST NAMES------------------------------------------------
        public static List<string> Names() 
        {
            List<string> names = new List<string>()
            {
                "Todd", 
                "Tiffany", 
                "Charlie", 
                "Geneva", 
                "Sydney"
            };

            Random rand = new Random();

            //Shuffle Names and display new order
            for(var i = 0; i < names.Count/2; i++) 
            {
                //Swap names[i] with names[randomIndex]
                int randomIndex = rand.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }
            
            //print new order of names
            foreach(var name in names) 
            {
                Console.WriteLine("-" + name);
            }

            //Show names with 5 or More Characters
            Console.WriteLine("--------------------Showing Names With Less Than 5 Characters Below----------------------");

            //Loop through names and check for length less than 5 characters
            for (var i = 0; i < names.Count; i++) 
            {
                if (names[i].Length <= 5)
                {
                    names.Remove(names[i]);
                }
            }
            
            //Print names again without
            foreach(var name in names) 
            {
                Console.WriteLine("-" + name);
            }
            
            return names;
        }
    }
}
