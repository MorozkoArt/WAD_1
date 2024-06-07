using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Person : InterfacePerson
    {
        public string CardName
        {
            get { return CardName1; }
            set { CardName1 = value; }
        }
        string CardName1;

        public string Name
        {
            get { return Name1; }
            set { Name1 = value; }
        }
        string Name1;

        public DateTime Birthday
        {
            get { return Birthday1; }
            set { Birthday1 = value; }
        }
        DateTime Birthday1;

        public int calcAge(DateTime date)
        {
            if (date.DayOfYear >= Birthday.DayOfYear)
                return date.Year - Birthday.Year;
            else
                return date.Year - Birthday.Year - 1;
        }
    }
}
