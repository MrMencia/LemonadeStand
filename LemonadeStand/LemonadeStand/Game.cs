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



        //Constructor (Creator)
        public Game()
        {
            days = new List<Day>();
            numberOfDaysPlayed = 7;
        }

        //Methods

        public void RunGame() // Master Method to run the whole Game!
        {
            DisplayRules();
            GenerateDays();

            for (int i = 0; i < days.Count; i++)
            {
                ShowGameMenu(days[i]);

            }


        }

      
        



        public void DisplayRules()
        {
            Console.WriteLine("Here are the Rules!:\n\n");
            Console.WriteLine("You have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand! You’ll have complete control over your business, including pricing, quality control, inventory control, and purchasing supplies. Buy your ingredients, set your recipe, and start selling!\n\nThe first thing you’ll have to worry about is your recipe. At first, go with the default recipe, but try to experiment a little bit and see if you can find a better one.Make sure you buy enough of all your ingredients, or you won’t be able to sell! \n\nYou’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade. Read the weather report every day!When the temperature drops, or the weather turns bad(overcast, cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, hazy day, so buy accordingly.Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.\n\nThe other major factor which comes into play is your customer’s satisfaction. As you sell your lemonade, people will decide how much they like or dislike it.  This will make your business more or less popular.If your popularity is low, fewer people will want to buy your lemonade, even if the weather is hot and sunny.But if you’re popularity is high, you’ll do okay, even on a rainy day!\n\nAt the end of 7, 14, or 21 days you’ll see how much money you made.Play again, and try to beat your high score!\n\n\n");
        }


    public void GenerateDays()
    {
        for (int i = 0; i < numberOfDaysPlayed; i++)
        {
            Day day = new Day();
            days.Add(day);
        }
    }
        public void ShowGameMenu(Day day) //Method for Showing Menu
        {
            bool menuItem = true;
            while (menuItem)

            {
                Console.WriteLine("Where would you like to go?:\n\n Choose one:\n\n To purchase Inventory, enter -> Inventory <-\nTo go to store? If so, enter -> Store <- \nWould you like to view the forecast for the day? If so, enter -> Forecast <- \nIf you're ready to sell that delicious lemonade, enter -> Sell<-");
                String option = Console.ReadLine();

                switch (option)

                {
                    case "Inventory": 

                        Console.WriteLine("Here are your options of what to purchase:\n\n To Purchase Lemons at .10 cents each, enter -> buy lemons<-\n\n To Purchase Cups at .05 cents each, enter ->Cups<-\n\n To Purchase Ice for .02 cents each, enter -> Ice<-\n\nIf you have all your ingredients and are ready to start selling delicious lemonade, enter -> Sell<-\n\n\n**** REMEMBER TO CHECK YOUR FORECAST! THE WEATHER DOES AFFECT HOW MUCH YOU SELL!****");
                        //Generate how many cups and for what price
                        break;

                    case "Store":

                        Console.WriteLine("How many Lemons would you like to purchase?");
                        //Genrate how many lemons they would like to purchase and for how much.....
                        break;

                    case "Forecast":

                        Console.WriteLine("Today is: " + day.weather.temperature + " " + day.weather.condition);
                        //Genereate how many cups of sugar they would like to purchase and for how much.....
                        break;

                    case "Sell":

                        Console.WriteLine("Good Luck!");
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
        
    
    