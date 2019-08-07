using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day
    {
        //Member Variables (Has A....)

        public Weather weather;
        public string condition;
        public int temperature;
        public List<int> daysYourePlaying;
        public List<Customer> customer;




        //Constructor
        public Day()
        {
            weather = new Weather();
            condition = null;
            temperature = 0;
            customer = new List<Customer>
            daysYourePlaying = new List<int>() { 1, 2, 3, 4, 5 };
        }







        //Methods

        

    }
}
