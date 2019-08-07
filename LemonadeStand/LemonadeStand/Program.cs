using System;

namespace LemonadeStand
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Game game = new Game();
            game.RunGame();

            Console.ReadKey();
            /*
            Weather weather;
            weather = new Weather();

            string a = "Todays weather is " + weather.condition + " and todays temperature is:" + weather.temperature ;

            Console.WriteLine(a);

            weather.GenerateCondition();
            */

        }
    }
}
