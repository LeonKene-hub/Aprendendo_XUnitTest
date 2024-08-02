using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorEmail
{
    public static class Email
    {
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Email valido");
                return true;
            }
            else
            {
                Console.WriteLine("Email invalido");
                return false;
            }
        }
    }
}
