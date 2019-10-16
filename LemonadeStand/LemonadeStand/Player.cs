using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        public string playerName;
        public Inventory inventory;


        //construct


        //methods
        public string ChooseName()
        {
            Console.WriteLine("Please choose a name for your Lemonade Stand!");
            playerName = Console.ReadLine();
            return playerName;
        }
    }
}
