using GenValidation.Service.Utilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenValidation.Service.Utilities.Implementation
{
    public class EmailValidator : IEmailValidator
    {
        public bool IsValidEmail(string email)
        {
            try
            {
                var trimmedEmail = email.Trim();

                if (trimmedEmail.EndsWith("."))
                {
                    return false;
                }

                var addr = new System.Net.Mail.MailAddress(email);
                return string.Equals(addr.Address, trimmedEmail);
            }
            catch
            {
                return false;
            }
        }
    }
}
