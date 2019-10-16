using System;
namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        public int iceCubes;
        public int lemons;
        public int sugar;
        public int cups;
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int iceCubesPerPitcher;
        public int cupsPerPitcher;
        public double moneyCounter;
        public int pitcherCounter;

        //construct
        public Inventory(int sugar, int lemons, int iceCubes, int cups)
        {
            moneyCounter = 20;
            moneyCounter = Math.Round(moneyCounter, 2);
            cupsPerPitcher = 5;
            pitcherCounter = 0;
        }



        //methods
        public int PlanPitchersLemon()
        {
            Console.WriteLine("How many lemons would you like to place in each pitcher?");
            while (int.TryParse(Console.ReadLine(), out lemonsPerPitcher))
            {
                return lemonsPerPitcher;
            }
            return PlanPitchersLemon();
        }
        public int PlanPitchersSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to place in each pitcher?");
            while (int.TryParse(Console.ReadLine(), out sugarPerPitcher))
            {
                return sugarPerPitcher;
            }
            return PlanPitchersSugar();
        }
        public int PlanPitchersIce()
        {
            Console.WriteLine("How many ice cubes would you like to place in each pitcher?");
            while (int.TryParse(Console.ReadLine(), out iceCubesPerPitcher))
            {
                return iceCubesPerPitcher;
            }
            return PlanPitchersIce();
        }
        public int MakePitchers()
        {
            while (lemons >= lemonsPerPitcher && sugar >= sugarPerPitcher && iceCubes >= iceCubesPerPitcher && cups >= cupsPerPitcher)
            {
                lemons -= lemonsPerPitcher;
                sugar -= sugarPerPitcher;
                cups -= cupsPerPitcher;
                iceCubes -= iceCubesPerPitcher;
                pitcherCounter++;
            }
            return pitcherCounter;
        }
    }
}

