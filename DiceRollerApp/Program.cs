using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerApp;

namespace DiceRolConsoleApplication_LabFive_31AuglerApp
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            Console.WriteLine(string.Format("Welcome to the Grand Circus Casino!"));
            Random rnd = new Random();
            Console.WriteLine("Roll the dice?(y/n)");
            string reply = Console.ReadLine();
            int counter = 1;
            int numberOfSide;

            while (reply.Trim().ToLower() == "y")
            {
                Console.WriteLine("Enter the number of sides for a pair of dice ?");
                bool side = int.TryParse(Console.ReadLine(), out numberOfSide);
                if (side == true)
                {
                    Console.WriteLine($"Roll : {counter}");
                    int dice1 = rnd.Next(1, numberOfSide);
                    int dice2 = rnd.Next(1, numberOfSide);
                    Console.WriteLine($"{dice1} \n{dice2}");
                    // Console.WriteLine(string.Format("{0}\n{1}", dice1, dice2));                  
                    // Console.WriteLine((dice2));                    
                    DiceRoll roll = new DiceRoll();
                    roll.messageDice(dice1, dice2);
                    counter++;
                    Console.WriteLine("Roll again?(y/n)");
                    reply = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter an interger");
                }
            }
            Console.Clear();
            Console.WriteLine("\nAre you sure you don't want to play?");
        }
    }
}