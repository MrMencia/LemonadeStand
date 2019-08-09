using System;
namespace LemonadeStand
{
    public class Store
    {
        //Member Variables (Has a....)

        public string goToStore;
        public string sellLemonade;
        public string viewInventory;
        public string viewForecast;

        public double lemonPrice;
        public double cupPrice;
        public double icePrice;
        public double lemonadePrice;
        public double sugarPrice;




        //Constructor
        public Store()
        {
            goToStore = null;
            sellLemonade = null;
            viewInventory = null;
            viewForecast = null;


            lemonPrice = .10;
            cupPrice = .05;
            icePrice = .02;
            sugarPrice = .01;
            lemonadePrice = .50;


        }




        //Methods

        // (This equation calculates the purchase of items. For the below example, it increases the inventory and decreases the amount of cash you have!)

        public void SellLemons(Player player)

        {
            Console.WriteLine("Your current money is: " + player.inventory.cash);
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemons = int.Parse(Console.ReadLine());
            double cost = lemons * lemonPrice;
            Console.WriteLine("This costs: " + cost);
            if (player.inventory.cash >= cost)
            {
                player.inventory.Lemons += lemons;

                player.inventory.cash -= cost;
            }

            else
            {
                Console.WriteLine("You dont have enough money man! Buy what you can afford! ");
            }

        }

        public void SellCups(Player player)

        {
            Console.WriteLine("Your current money is: " + player.inventory.cash);
            Console.WriteLine("How many Cups would you like to purchase?");
            int Cups = int.Parse(Console.ReadLine());
            double cost = Cups * cupPrice;

            if (player.inventory.cash >= cost)
            {
                player.inventory.Cups += Cups;

                player.inventory.cash -= cost;
            }

            else
            {
                Console.WriteLine("You dont have enough money man! Buy what you can afford!");
                SellCups(player);
            }

        }
        public void SellIce(Player player)

        {
            Console.WriteLine("Your current money is: " + player.inventory.cash);
            Console.WriteLine("How many ice cubes would you like to purchase?");
            int Ice = int.Parse(Console.ReadLine());
            double cost = Ice * icePrice;

            if (player.inventory.cash >= cost)
            {
                player.inventory.Ice += Ice;

                player.inventory.cash -= cost;
            }

            else
            {
                Console.WriteLine("You dont have enough money man! Buy what you can afford! ");
                SellIce(player);
            }

        }


            public void SellSugar(Player player)

            {
            Console.WriteLine("Your current money is: " + player.inventory.cash);
            Console.WriteLine("How much sugar would you like to purchase?");
                int Sugar = int.Parse(Console.ReadLine());
                double cost = Sugar * icePrice;

                if (player.inventory.cash >= cost)
                {
                    player.inventory.Sugar += Sugar;

                    player.inventory.cash -= cost;
                }

                else
                {
                    Console.WriteLine("You dont have enough money man! Buy what you can afford! ");
                SellSugar(player);
                }
            

            }

        public void SellLemonade(Player player)

        {
            Console.WriteLine("Your current money is: " + player.inventory.cash);
            Console.WriteLine("Lets get this money! :) ");
            int Lemonade = int.Parse(Console.ReadLine());
            double cost = Lemonade * icePrice;

            if (player.inventory.cash >= cost)
            {
                player.inventory.Sugar += Lemonade;

                player.inventory.cash -= cost;
            }

            else
            {
                Console.WriteLine("You dont have enough money man! Buy what you can afford! ");
                SellLemonade(player);
            }


        }

        public void showMenuItems() //Method for Showing Menu
        {
            bool storeMenuItems = true;

            while (storeMenuItems)

            {
                Console.WriteLine("What would you like to Purchase?:\n Choose one:\n\nTo Buy Paper Cups?\n enter -> Cups <-\n Buy Lemons?\n enter -> Lemons <-\n Buy Cups of Sugar?\n enter -> Sugar <-\n Buy Ice Cubes\n enter -> Ice <-\n\nTo go back and see other options, enter -> back <- ");
                String option = Console.ReadLine();

                switch (option)
                { 
                
                case "Cups":
                
                    Console.WriteLine("How many Cups would you like to purchase?");
                    //Generate how many cups and for what price
                    break;

                case "Lemons":
                
                        Console.WriteLine("How many Lemons would you like to purchase?");
                    //Genrate how many lemons they would like to purchase and for how much.....
                    break;

                 case "Sugar":
                
                        Console.WriteLine("How many cups of Sugar would you like to purchase?");
                    //Genereate how many cups of sugar they would like to purchase and for how much.....
                    break;

                 case "Ice":
                
                        Console.WriteLine("How many cubes of Ice would you like to purchase?");
                    //Generate how many cubes of ice you would like to purchase.....
                    break;
                    


                 case "Back":
                
                        Console.WriteLine("Please enter Back to go back to the Main Menu");
                        storeMenuItems = false;
                    break;

                    default:
                        break;



                }
            }
        }

    }

}