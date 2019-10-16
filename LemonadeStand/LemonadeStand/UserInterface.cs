using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    public class UserInterface
    {
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("\nYou now have $" + inventory.moneyCounter + " and the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups.\n");
        }
        public static void EndDay(Inventory inventory)
        {
            Console.WriteLine("You ended today with $" + inventory.moneyCounter + ". and all of your ice has melted");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BeginDay(Inventory inventory, Player player1)
        {
            if (inventory.moneyCounter >= 20)
            {
                Console.WriteLine("You have made $" + (inventory.moneyCounter - 20) + " so far.");
            }
            else
            {
                Console.WriteLine("You have lost $" + (20 - inventory.moneyCounter) + " so far.");
            }
            Console.WriteLine(player1.playerName + " is about to open for today. You have $" + inventory.moneyCounter + ".\n");
            Console.ReadLine();
            Console.WriteLine("Your Lemonade Stand forecast is below, temperature followed by conditions\n");
        }
        public static void EndGame(Inventory inventory, Player player1)
        {
            if (inventory.moneyCounter >= 20)
            {
                Console.WriteLine("You were able to make $" + (inventory.moneyCounter - 20) + " from " + player1.playerName + ".");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have lost $" + (20 - inventory.moneyCounter) + ".");
                Console.ReadLine();
            }
            Console.WriteLine("The game is over! Please play again and try to make even more money next time!");
            Console.ReadLine();
        }
        public static void TodayWeather(Day day)
        {
            Console.WriteLine("Today is " + day.weather.temperature + " degrees and it is " + day.weather.condition + ".\n");
        }

        public static void OutOfMoney(Store store)
        {
            Console.WriteLine("You do not have enough money to continue the game.");
            Console.WriteLine("Take your $" + store.inventory.moneyCounter + " home and rethink your life.");
            Console.ReadLine();
        }
        public static void AskToSell(Game game)
        {
            Console.WriteLine("Would you like to attempt selling lemonade in this weather?");
            switch (Console.ReadLine())
            {
                case "yes":
                    Console.WriteLine("Great! Lets go to the store.");
                    Console.ReadLine();
                    break;
                case "no":
                    Console.WriteLine("You chose to skip a day of selling lemonade");
                    game.FinishDay();
                    game.GenerateForecast();
                    Console.Clear();
                    UserInterface.TodayWeather(game.days[game.dayCounter - 1]);
                    AskToSell(game);
                    break;
                default:
                    Console.WriteLine("please enter 'yes' or 'no'");
                    AskToSell(game);
                    break;
            }

        }
    }
    }

