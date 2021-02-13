using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_5_dice_rolls
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int[] dice = new int[5];
            int sum = 0;
            dice[0] = x.Next(1, 7);
            dice[1] = x.Next(1, 7);
            dice[2] = x.Next(1, 7);
            dice[3] = x.Next(1, 7);
            dice[4] = x.Next(1, 7);
            sum += dice[0] + dice[1] + dice[2] + dice[3] + dice[4];
            Console.Write("Dice 1: " + dice[0] + "\nDice 2: " + dice[1] + "\nDice 3: " + dice[2] + "\nDice 4: " + dice[3] + "\nDice 5: " + dice[4] + "\n");
            Console.WriteLine("Total sum of 5 dice rolls: " + sum);
            Console.ReadKey();
        }
    }
}
