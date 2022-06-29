using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class NewUserValidationService:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}

/*yeni bir doğrulama sistemi istendiğinde ana sistemin buna adapte olabildiğini
göstermek için yapıldı*/

    

