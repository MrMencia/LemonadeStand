using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    public class Customer
    {

        //member variables

        public int temperatureThreshold;
        public double availableCash;
        public Random random;


        //construct
        public Customer(Random random)
        {
            this.random = random;
            GiveCash();
            GiveThreshold();
        }
        //methods
        public void GiveThreshold()
        {
            temperatureThreshold = random.Next(60, 90);
        }
        public void GiveCash()
        {
            availableCash = random.Next(2, 10) / 10;
        }
    }
}







    

