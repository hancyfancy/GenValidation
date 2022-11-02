using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenValidation.Service.Utilities.Interface
{
    public interface IEmailValidator
    {
        bool IsValidEmail(string email);
    }
}
