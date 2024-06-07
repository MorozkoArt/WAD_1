using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public interface InterfacePerson
    {
        string CardName { get; }
        string Name { get; }
        DateTime Birthday { get; }
        int calcAge(DateTime date);
    }
}
