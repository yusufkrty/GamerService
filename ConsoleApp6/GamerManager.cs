using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
   
        class GamerManager : IGamerService
        {
            IUserValidationService _userValidationService;

            public GamerManager(IUserValidationService userValidationService)
            {
                _userValidationService = userValidationService;
            }

            public void Add(Gamer gamer)
            {
                if (_userValidationService.Validate(gamer) == true)
                {
                    Console.WriteLine(gamer.FirstName + " İsimli oyuncu Eklendi.");
                }
                else
                {
                    Console.WriteLine("Doğrulama başarısız,kayıt yapılmadı.");
                }

            }

            public void Delete(Gamer gamer)
            {
                Console.WriteLine(gamer.FirstName + " İsimli oyuncu Silindi.");
            }

            public void Update(Gamer gamer)
            {
                Console.WriteLine(gamer.FirstName + " İsimli oyuncu Güncellendi.");
            }
        }
}
