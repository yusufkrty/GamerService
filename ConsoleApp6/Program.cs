using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "YUSUF",
                LastName = "KARATAY",
                BirthYear = 2001,
                IdentityNumber = 12345
            });



            OfferManager offerManager = new OfferManager();
            float a = offerManager.MakeOffer(new Games
            {
                GameName = "Valorant",
                GameExplanation = "Rekabetçi FPS Oyunu",
                GamePrice = 100,
                GameYear = 2019
            },
            new Offer { OfferPercent = 0.2f });
            Console.WriteLine(a);

            GameSellerManager gameSellerManager = new GameSellerManager();
            gameSellerManager.Sell(new Gamer
            {
                Id = 1,
                FirstName = "YUSUF",
                LastName = "KARATAY",
                BirthYear = 2001,
                IdentityNumber = 12345
            }, new Games
            {
                GameName = "Valorant",
                GameExplanation = "Rekabetçi FPS Oyunu",
                GamePrice = 100,
                GameYear = 2019
            });

        }
    }
}
