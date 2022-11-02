using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenValidation.Service.Utilities.Interface
{
    public interface IPhoneValidator
    {
        bool IsValidPhone(string number);
    }
}
