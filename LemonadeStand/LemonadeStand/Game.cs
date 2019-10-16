using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LemonadeStand
{
    public class Game

    {
        //Member Variables (Has A....)

        public Player player1;
        public int dayCounter;
        public List<Day> days;
        private double cupCharge;
        Random random = new Random();
        public int totalDays;
        private List<Customer> servedTemperature;
        private List<Customer> served;
        private int cupsLemonade;
        Store store = new Store();

        //construct
        public Game()
        {
            dayCounter = 1;
        }
        //methods

        public List<Day> GenerateDays()
        {
            days = new List<Day>();
            for (int i = 1; i <= totalDays; i++)
            {
                days.Add(new Day(random));
            }
            return days;
        }
        public void RunGame()
        {
            Console.WriteLine("Your Lemonade Stand starts with $20.\nYou are able to purchase new supplies and ingredients each day before selling.\nCustomers will decide whether they want to buy your product based on various circumstances.\nYou will have the option to buy and sell each day for as many days as you would like, up to 30, to maximize profits.\nEach pitcher of lemonade yields 5 cups, and ingredients are used to make as many pitchers possible each day.\nSpend your money and craft your pitchers wisely!");
            player1 = new Player();
            Console.ReadLine();
            player1.ChooseName();
            PromptDays();
            GenerateDays();
            while (dayCounter <= totalDays)
            {
                if (store.inventory.lemons == 0 && store.inventory.moneyCounter < store.lemonPrice)
                {
                    UserInterface.OutOfMoney(store);
                    return;
                }
                else if (store.inventory.sugar == 0 && store.inventory.moneyCounter < store.sugarPrice)
                {
                    UserInterface.OutOfMoney(store);
                    return;
                }
                else if (store.inventory.iceCubes == 0 && store.inventory.moneyCounter < store.icePrice)
                {
                    UserInterface.OutOfMoney(store);
                    return;
                }
                else if (store.inventory.cups == 0 && store.inventory.moneyCounter < store.cupPrice)
                {
                    UserInterface.OutOfMoney(store);
                    return;
                }
                else
                {
                    servedTemperature = new List<Customer>();
                    served = new List<Customer>();
                    UserInterface.BeginDay(store.inventory, player1);
                    GenerateForecast();
                    Console.Clear();
                    UserInterface.TodayWeather(days[dayCounter - 1]);

                    UserInterface.AskToSell(this);

                    UserInterface.DisplayInventory(store.inventory);
                    store.PurchaseSugar();
                    UserInterface.DisplayInventory(store.inventory);
                    store.PurchaseLemons();
                    UserInterface.DisplayInventory(store.inventory);
                    store.PurchaseIce();
                    UserInterface.DisplayInventory(store.inventory);
                    store.PurchaseCups();
                    UserInterface.DisplayInventory(store.inventory);
                    Console.Clear();
                    UserInterface.DisplayInventory(store.inventory);
                    store.inventory.PlanPitchersSugar();
                    store.inventory.PlanPitchersLemon();
                    store.inventory.PlanPitchersIce();
                    Console.Clear();
                    GetCupCharge();
                    store.inventory.MakePitchers();
                    Console.WriteLine("Made " + store.inventory.pitcherCounter + " pitchers.");
                    Console.ReadLine();
                    cupsLemonade = store.inventory.pitcherCounter * 5;
                    Console.WriteLine("Made " + cupsLemonade + " cups.");
                    if (store.inventory.lemonsPerPitcher == 0)
                    {
                        Console.WriteLine("Nobody wanted lemonade with no lemons!");
                        UserInterface.EndDay(store.inventory);
                    }
                    else if (store.inventory.sugarPerPitcher == 0)
                    {
                        Console.WriteLine("Nobody wanted lemonade with no sugar in it!");
                        UserInterface.EndDay(store.inventory);
                    }
                    else if (store.inventory.iceCubesPerPitcher == 0)
                    {
                        Console.WriteLine("Your lemonade was warm and gross with no ice in it!");
                        UserInterface.EndDay(store.inventory);
                    }
                    else
                    {
                        Console.ReadLine();
                        customersServedTemperature(days[dayCounter - 1].customers, days[dayCounter - 1].weather.temperature);
                        for (int i = 0; i < servedTemperature.Count; i++)
                        {
                            customersServed(servedTemperature, servedTemperature[i].availableCash);
                        }
                        if (served.Count > cupsLemonade)
                        {
                            Console.WriteLine("You ran out of lemonade before the end of the day.");
                            store.inventory.moneyCounter += cupsLemonade * cupCharge;
                        }
                        else
                        {
                            Console.WriteLine("Out of the " + (cupsLemonade) + " cups of lemonade you made, you served " + served.Count + " customers!");
                            store.inventory.moneyCounter += served.Count * cupCharge;
                        }
                        UserInterface.EndDay(store.inventory);
                    }
                }
                FinishDay();
            }
            UserInterface.EndGame(store.inventory, player1);
        }
        List<Customer> customersServedTemperature(List<Customer> customers, int temperature)
        {
            servedTemperature = new List<Customer>();
            foreach (var customer in customers)
            {
                if (customer.temperatureThreshold <= temperature)
                {
                    servedTemperature.Add(customer);
                }
            }
            return servedTemperature;
        }
        List<Customer> customersServed(List<Customer> servedTemperature, double availableCash)
        {
            served = new List<Customer>();
            foreach (var customer in servedTemperature)
            {
                if (customer.availableCash <= cupCharge)
                {
                    served.Add(customer);
                }
            }
            return served;
        }
        public void GenerateForecast()
        {
            if ((totalDays - dayCounter) - 7 >= 0)
            {
                for (int i = dayCounter - 1; i <= dayCounter + 5; i++)
                {
                    Console.WriteLine(days[i].weather.temperature + " " + days[i].weather.condition);
                }
            }
            else
            {
                for (int i = dayCounter - 1; i <= totalDays - 1; i++)
                {
                    Console.WriteLine(days[i].weather.temperature + " " + days[i].weather.condition);
                }
            }
            Console.ReadLine();
        }
        public double GetCupCharge()
        {
            Console.WriteLine("You are done buying supplies and making pitchers for today. How much would you like to charge per cup of lemonade in cents?");
            while (double.TryParse(Console.ReadLine(), out cupCharge))
            {
                cupCharge *= 0.01;
                return (cupCharge);
            }
            return GetCupCharge();
        }
        private int PromptDays()
        {
            Console.WriteLine("How many days (max: 30) will your stand be open?");
            while (int.TryParse(Console.ReadLine(), out totalDays) && totalDays <= 30 && totalDays > 0)
            {
                return totalDays;
            }
            Console.WriteLine("Please choose a number of days between 1 and 30");
            return PromptDays();
        }
        public void FinishDay()
        {
            store.inventory.pitcherCounter = 0;
            cupsLemonade = 0;
            store.inventory.iceCubes = 0;
            dayCounter++;
        }


    }
}

        
    
    