using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {

        public int numberOfCustomers;
        public Weather weather;
        public Customer customer;
        public List<Customer> customers;
        Random random;
        //construct
        public Day(Random random)
        {
            this.random = random;
            customer = new Customer(random);
            customers = new List<Customer>();
            weather = new Weather(random);
            weather.GenerateConditions();
            weather.GenerateTemperature();
            GenerateCustomers();
        }

        //methods
        public List<Customer> GenerateCustomers()
        {
            if (weather.condition == "sunny" || weather.condition == "partly cloudy")
            {
                numberOfCustomers = customer.random.Next(80, 100);
                for (int i = 1; i <= numberOfCustomers; i++)
                {
                    customers.Add(new Customer(random));
                }
                return customers;
            }
            else if (weather.condition == "overcast")
            {
                numberOfCustomers = customer.random.Next(60, 85);
                for (int i = 1; i <= numberOfCustomers; i++)
                {
                    customers.Add(new Customer(random));
                }
                return customers;
            }
            else
            {
                numberOfCustomers = customer.random.Next(40, 70);
                for (int i = 1; i <= numberOfCustomers; i++)
                {
                    customers.Add(new Customer(random));
                }
                return customers;
            }
        }



    }


}

