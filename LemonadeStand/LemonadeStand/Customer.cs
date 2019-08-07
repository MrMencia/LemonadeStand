using System;
namespace LemonadeStand
{
    public class Customer
    {
        //Member Variables (Has A.....)

        public int chanceToBuy;


        //Constructor (Creator)
        public Customer()
        {
            Random rand = new Random();

            chanceToBuy = rand.Next(40, 60);

        }


        public void AdjustForWeather(Weather weather)
        {
            Random rand = new Random();

        }

        //Methods
    }
}
