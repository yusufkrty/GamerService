using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class OfferManager:IOfferService
    {
        public float MakeOffer(Games games, Offer offer)
        {
            float newPrice = games.GamePrice - (games.GamePrice * offer.OfferPercent);
            return newPrice;
        }
    }
}
