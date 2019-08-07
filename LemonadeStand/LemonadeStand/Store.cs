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




        //Constructor
        public Store()
        {
            goToStore = null;
            sellLemonade = null;
            viewInventory = null;
            viewForecast = null;

        }






        //Methods

        public void showMenuItems() //Method for Showing Menu
        {
            bool storeMenuItems = true;
            while (storeMenuItems)

            {
                Console.WriteLine("What would you like to Purchase?:\n Choose one:\n\n To Buy Paper Cups?\n enter Cups\n Buy Lemons?\n enter Lemons\n Buy Cups of Sugar?\n enter Sugar\n Buy Ice Cubes\n enter Ice ");
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
                    break;

                    default:
                        break;



                }
            }
        }

    }

}