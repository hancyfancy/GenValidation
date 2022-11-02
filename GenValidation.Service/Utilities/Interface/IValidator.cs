using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenValidation.Service.Utilities.Interface
{
    public interface IValidator
    {
        bool IsValid(string source);
    }
}
