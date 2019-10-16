using System;
namespace LemonadeStand
{
    public class Store

    {
        //member variables
        public int sugarSale;
        public int iceSale;
        public int lemonSale;
        public int cupSale;
        public double sugarPrice;
        public double icePrice;
        public double lemonPrice;
        public double cupPrice;
        public Inventory inventory;

        //construct
        public Store()
        {
            this.inventory = new Inventory(0, 0, 0, 0);
            sugarPrice = 0.10;
            icePrice = 0.03;
            lemonPrice = 0.30;
            cupPrice = 0.07;
        }

        //methods
        public int PurchaseSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?\nSugar costs " + sugarPrice + " cents per cup.");
            while (int.TryParse(Console.ReadLine(), out sugarSale) && sugarSale >= 0)
            {
                if (sugarSale * sugarPrice > inventory.moneyCounter)
                {
                    Console.WriteLine("You cannot afford this many cups of sugar. Try again.");
                    return PurchaseSugar();
                }
                else
                {
                    inventory.moneyCounter -= (sugarSale * sugarPrice);
                    inventory.sugar += sugarSale;
                    return inventory.sugar;
                }
            }
            Console.WriteLine("Please enter a whole number to purchase");
            return PurchaseSugar();
        }
        public int PurchaseLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?\nLemons costs " + lemonPrice + " cents each.");
            while (int.TryParse(Console.ReadLine(), out lemonSale))
            {
                if (lemonSale * lemonPrice > inventory.moneyCounter)
                {
                    Console.WriteLine("You cannot afford this many lemons. Try again.");
                    lemonSale = 0;
                    return PurchaseLemons();
                }
                else
                {
                    inventory.moneyCounter -= (lemonSale * lemonPrice);
                    inventory.lemons += lemonSale;
                    return inventory.lemons;
                }
            }
            Console.WriteLine("Please enter a whole number to purchase");
            return PurchaseLemons();
        }
        public int PurchaseIce()
        {
            Console.WriteLine("How many ice cubes would you like to buy?\nIce costs " + icePrice + " cents per cube.");
            while (int.TryParse(Console.ReadLine(), out iceSale))
            {
                if (iceSale * icePrice > inventory.moneyCounter)
                {
                    Console.WriteLine("You cannot afford this many ice cubes. Try again.");
                    iceSale = 0;
                    return PurchaseIce();
                }
                else
                {
                    inventory.moneyCounter -= (iceSale * icePrice);
                    inventory.iceCubes += iceSale;
                    return inventory.iceCubes;
                }
            }
            Console.WriteLine("Please enter a whole number to purchase");
            return PurchaseIce();
        }
        public int PurchaseCups()
        {
            Console.WriteLine("How many cups would you like to buy?\nCups cost " + cupPrice + " cents each.");
            while (int.TryParse(Console.ReadLine(), out cupSale))
            {
                if (cupSale * cupPrice > inventory.moneyCounter)
                {
                    Console.WriteLine("You cannot afford this many cups. Try again.");
                    cupSale = 0;
                    return PurchaseCups();
                }
                else
                {
                    inventory.moneyCounter -= (cupSale * cupPrice);
                    inventory.cups += cupSale;
                    return inventory.cups;
                }
            }
            Console.WriteLine("Please enter a whole number to purchase");
            return PurchaseCups();
        }


    }

}