using System;
namespace LemonadeStand
{
    public class Customer
    {
        //Member Variables (Has A.....)

        public int chanceToBuy;
        public int tempPreference;
        public int condPreference;
        public int costPreference;
        public bool custWillBuy;
        public int numberToCompare;
        public bool custDecision;



        //Constructor (Creator)

        

        public Customer()
        {
            Random rand = new Random();
            chanceToBuy = rand.Next(40, 61);

        }

        public void AdjustForWeather(Weather weather)
        {
            Random rand = new Random();

        }



        //Methods






        public bool CustomerDecision()
        {
            if (chanceToBuy > numberToCompare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void GetCustomerChanceToBuy()
        {
            Random random = new Random();
            chanceToBuy = random.Next(40, 60);
        }


        public void CompareNumberToBuy()
        {
            Random random = new Random();
            numberToCompare = random.Next(1, 100);
            
        }


        public void AdjustChanceBasedOnTemp(Weather weather)
        {
            if (weather.temperature < 50)
            {
                chanceToBuy -= 10;
            }
            else if (weather.temperature >= 51 && weather.temperature <= 60)
            {
                chanceToBuy -= 5;
            }
            else if (weather.temperature >= 61 && weather.temperature <= 70)
            {
                chanceToBuy += 5;
            }
            else if (weather.temperature >= 71 && weather.temperature <= 80)
            {
                chanceToBuy += 10;
            }
            else if (weather.temperature >= 81 && weather.temperature <= 90)
            {
                chanceToBuy += 15;
            }
            else
            {
                chanceToBuy += 20;
            }
        }


        public void AdjustChanceBasedOnCond(Weather weather)
        {
            if (weather.condition == "Sunny")
            {
                chanceToBuy += 20;
            }
            else if (weather.condition == "Raining")
            {
                chanceToBuy -= 5;
            }
            else if (weather.condition == "Foggy")
            {
                chanceToBuy += 5;
            }
            else if (weather.condition == "Snowing")
            {
                chanceToBuy -= 20;
            }
            else
            {
                chanceToBuy += 20;
            }

        }
        public void AdjustCostPreference()
        {
            Random rand = new Random();
            int ProbablityofPurchase = rand.Next(1, 3);

            if(ProbablityofPurchase == 1)
            {
                chanceToBuy += 10;
            }
            else
            {
                chanceToBuy -= 10;
            }
        }
    }
}






    

