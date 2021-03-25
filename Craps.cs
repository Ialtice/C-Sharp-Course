/*
 * Name: Isaac Altice
 * Date: 01/27/2020
 * Course: ITCS-3112-051
 * 
 * Project Name: Craps
 * Description: A program that lets a user start playing a game of craps with a start of 100 chips
 * until they choose to stop playing.
 */

using System; //Required 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CrapsProgram 
{
    class Craps 
    {
        static void Main(string[] args) 
        {
            // declare required variables
            string playGame = "Y";//varaible to hold y or n to continue playing the game
            int chips = 100;// chips holds the number of chips the user has
            int rollSum;// hold the value of the two die added together
            int point;// holds the craps game point value
            int wager;// holds the number of chips bet 
            

            Console.WriteLine("Welcome to Craps!");//displays welcome message to the user 
            Console.WriteLine("You have 100 chips.");
            Console.WriteLine("Lets play a game");
            
            while (playGame.Equals("Y") && chips > 0)//continues the game until the the player runs out of chips or chooses to quit
            {
                Console.Write("Enter a wager : ");//asks user for a wager
                wager = int.Parse(Console.ReadLine());// takes wager as a string value and parse to int 
                Wager(wager);//displays back wager to the user
                rollSum = RollDice();// the first roll of the game
                switch(rollSum)//switch statement  for 3 scenarios, instant win, instnt loss, or roll until point is made or a loss is rolled
                {
                    case 7://if rolled 7 or 11 instant win
                    case 11:
                        chips += wager;//adds wager to the chip count
                        Console.WriteLine("You won!");//display winning message to user and total chips the user has
                        Console.WriteLine("Your current chip total is: " + chips);
                        Console.WriteLine("Do you wish to play a game of Craps ? (Y / N)");// asks user if they want to play another game
                        playGame = Console.ReadLine().ToUpper();//changing user input always to upper case
                        break;
                    case 2:// if rolled 2,3,12 instant loss
                    case 3:
                    case 12:
                        chips -= wager;//subtracts wager from chip count
                        Console.WriteLine("You lost!");//display loss message to user and new chip amount
                        Console.WriteLine("Your current chip total is: " + chips);
                        Console.WriteLine("Do you wish to play a game of Craps ? (Y / N)");//asks user if they want to play another game
                        playGame = Console.ReadLine().ToUpper();//changing user input always to upper case
                        break;
                    default:// if any other numbers rolled craps is played
                        point = rollSum;// point is set from initial dice roll
                        Console.WriteLine("Your point is : " + point);//display point to the user
                        rollSum = RollDice();//rolls dice
                        while(rollSum != 7 && rollSum != point)//continue to roll dice until a 7 for a loss, or the point value
                        {
                            
                            rollSum = RollDice();// roll dice
                            
                        }
                        if (rollSum == point)//if point value is rolled display winning message and add chips to users total
                        {
                            Console.WriteLine("You won!");
                            chips += wager;
                        }
                        else// if losing number is rolled display losing message and subtract chips from users total
                        {
                            Console.WriteLine("You lost!");
                            chips -= wager;
                        }
                        Console.WriteLine("Your current chip total is: " + chips);//display users current chip total and asks if they would like to play again
                        Console.WriteLine("Do you wish to play a game of Craps ? (Y / N)");
                        playGame = Console.ReadLine().ToUpper();
                        break;

                }
               
                

            }
            Console.WriteLine("Your total winnings are " + chips + " chips.");// display finally chip count to user and say goodbye
            Console.WriteLine("Goodbye");

        }
        public static int RollDice()// method that rolls 2 dice, shows their value and sum to the user, returns the sum
        {
            Thread.Sleep(20);//sleep to avoid random number generator generating the same values for the next die rolls
            Random randomGenerator = new Random();

            int die1;
            int die2;
            int sum;
            die1 = randomGenerator.Next(1, 6);//generates a number 1-6 for a each die
            Thread.Sleep(20);
            die2 = randomGenerator.Next(1, 6);
            sum = die1 + die2; //sum the dies
            Console.WriteLine("You roll the dice ... " + die1 + " and " + die2);// display rool values and sum to user
            Console.WriteLine("The sum is : " + sum);
            return sum;
        }
        public static void Wager(int betChips) //method that displays the amount of chips bet back to the user.
        {
            Console.WriteLine("You bet " + betChips + " chips");
        }
    }
}
