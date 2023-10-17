using System;

namespace ForeachBinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code will use your counter variable bin, the temporary foreach variable items,
            //and your sum variable to report the current state of your inventory in a nicely formatted message.

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int item in inventory)
            {
                sum += item;
                bin++;
                Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }
    }
}
