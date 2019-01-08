using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class LoginProcess
    {
        public bool ValidateUserInput(string username, string password)
        {
            bool validated = true;
            try
            {
                if (username.Length == 0 || username.Length > 30)
                {
                    validated = false;
                }

                // check each character in username string , this assumes numbers are not allowed in username string
                foreach (char ch in username)
                {
                    if (ch >= '0' && ch <= '9')
                    {
                        validated = false;
                    }
                }

                // password must exist and should not be longer than 30 characters
                if (password.Length == 0 || password.Length > 30)
                {
                    validated = false;
                }
            }

            catch (Exception)
            {
                validated = false;
            }
            return validated;

        }
    }
}
