using GenValidation.Service.Utilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenValidation.Service.Utilities.Implementation
{
    public class PhoneValidator : IValidator
    {
        public bool IsValid(string number)
        {
            try
            {
                var phoneNumber = number.Trim()
                .Replace(" ", "")
                .Replace("-", "")
                .Replace("(", "")
                .Replace(")", "");

                return Regex.Match(phoneNumber, @"^\+\d{5,15}$").Success;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
