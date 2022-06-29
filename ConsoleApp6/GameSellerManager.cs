using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class GameSellerManager
    {
        public void Sell(Gamer gamer, Games game)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu " + game.GameName
                + " isimli oyunu satın aldı!");
        }
    }
}
