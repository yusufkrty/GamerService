using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "YUSUF"
                && gamer.LastName == "KARATAY" && gamer.IdentityNumber == 12345)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
