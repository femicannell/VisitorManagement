using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorManagement.Business
{
    public interface ITextFileOperations
    {
        IEnumerable<string> LoadConditionsText();
    }
}
