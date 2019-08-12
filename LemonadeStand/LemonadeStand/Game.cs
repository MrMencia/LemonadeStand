using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Game

    {
        //Member Variables (Has A....)

        Day day = new Day();

        List<Day> days;

        int numberOfDaysPlayed;

        private object userInput;

        Player player = new Player();

        Store store = new Store();



        //Constructor (Creator)
        public Game()
        {
            days = new List<Day>();
            numberOfDaysPlayed = 7;
        }

        //Methods

        public void RunGame() // Master Method to run the whole Game!
        {
            DisplayRules(); //1

            GenerateDays(); //


            for (int i = 0; i < days.Count; i++)  //3
            {
                ShowGameMenu(days[i]);

            }


            Console.Clear();

            SetInitialSupplies();


            Console.ReadLine();



        }





        public void DisplayRules()
        {
            Console.WriteLine("Here are the Rules!:\n\n");
            Console.WriteLine("You have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand! You’ll have complete control over your business, including pricing, quality control, inventory control, and purchasing supplies. Buy your ingredients, set your recipe, and start selling!\n\nThe first thing you’ll have to worry about is your recipe. At first, go with the default recipe, but try to experiment a little bit and see if you can find a better one.Make sure you buy enough of all your ingredients, or you won’t be able to sell! \n\nYou’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade. Read the weather report every day!When the temperature drops, or the weather turns bad(overcast, cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, hazy day, so buy accordingly.Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.\n\nThe other major factor which comes into play is your customer’s satisfaction. As you sell your lemonade, people will decide how much they like or dislike it.  This will make your business more or less popular.If your popularity is low, fewer people will want to buy your lemonade, even if the weather is hot and sunny.But if you’re popularity is high, you’ll do okay, even on a rainy day!\n\nAt the end of day 7, you’ll see how much money you made.Play again, and try to beat your high score!\n\n\n");
        }


        public void GenerateDays()

        {
            Console.WriteLine("How many days would you like to play for? Enter the number of days.");
            int numberOfDaysPlayed = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDaysPlayed; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }

        public void SetInitialSupplies()

        {
            store.SellLemons(player);
            store.SellCups(player);
            store.SellIce(player);
            store.SellSugar(player);
            store.SellLemonade(player);

        }








        public void ShowGameMenu(Day day) //Method for Showing Menu
        {
            bool menuItem = true;

            while (menuItem)

            {
                Console.WriteLine("Where would you like to go?:\n\n Choose one:\n\n To purchase Inventory, enter -> Inventory <-\nTo go to store? If so, enter -> Store <- \nWould you like to view the forecast for the day? If so, enter -> Forecast <- \nIf you're ready to sell that delicious lemonade, enter -> Sell <-");
                String option = Console.ReadLine();

                switch (option)

                {
                    case "Inventory":

                        Console.WriteLine("Here are your options of what to purchase:\n\n To Purchase 10 Lemons for a $1, enter -> lemons <-\n\n To Purchase 20 cups for a $1, enter -> Cups <-\n\n To Purchase 50 cubes of Ice for $1, enter -> Ice <-\n\nIf you would like to purchase 100 packets of sugar for $1, enter -> sugar <-\n\n\n**** REMEMBER TO CHECK YOUR FORECAST! THE WEATHER DOES AFFECT HOW MUCH YOU SELL!****");
                        Console.ReadLine();
                        player.inventory.DisplayInventory();
                        break;

                    case "Store":

                        Console.WriteLine("What Items would you like to purchase?\n\n To buy 10 lemons for a $1, enter -> lemons <-\n\nTo buy 20 cups for a $1 enter -> cups <-\n\n To buy 50 cubes of ice for a $1, enter -> ice <-\n\nTobuy");
                        Console.ReadLine();
                        store.showMenuItems();
                        //Genrate how many lemons they would like to purchase and for how much.....
                        break;

                    case "Forecast":

                        Console.WriteLine("Today is: " + day.weather.temperature + " " + day.weather.condition);
                        //Genereate the forecast for the day....
                        break;

                    case "Sell":

                        Console.WriteLine("Good Luck!");
                        store.SellLemonade(player);
                        //Generate how many cubes of ice you would like to purchase.....
                        break;



                    case "Back":

                        Console.WriteLine("Please enter Back to go back to the Main Menu");
                        break;

                    default:
                        break;

                }

            }
        }
    }
}

        
    
    