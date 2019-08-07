using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Weather
    {


        //member variables

        public string condition;
        public int temperature;
        public List<string> weatherTypes;


        //Constructor

        public Weather()
        {
            condition = null;
            temperature = 0;
            weatherTypes = new List<string>() { "Sunny", "Raining", "Foggy", "Snowing" };
            GenerateCondition();
            GenerateTemperature();
        }



        //Methods

        public void GenerateCondition()
        {
            Random rand = new Random();

            int randomNumber = rand.Next(3);
            condition = weatherTypes[randomNumber];

        }


        public void GenerateTemperature()
        {
            Random rand = new Random();

         

            if(condition == "Sunny")
            {
                temperature = rand.Next(80, 100);

                Console.WriteLine("Today is Sunny with a temperature of" + temperature);
            }
            else if (condition == "Raining")
            {
                temperature = rand.Next(65, 70);

                Console.WriteLine("Today is raining with a temperature of" + temperature);

            }

            else if (condition == "Foggy")
            {
                temperature = rand.Next(55, 65);

                Console.WriteLine("Today is foggy with a temperature of" + temperature);
            }

            else if (condition == "Snowing")
            {
                temperature = rand.Next(0, 25);

                Console.WriteLine("Today is snowing with a temperature of" + temperature);

            }

        }

    }
}
