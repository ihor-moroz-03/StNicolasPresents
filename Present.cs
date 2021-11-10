using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNicolasPresents
{
    struct Present
    {
        public string Toy, Candy, Greeting;

        public override string ToString() => $"toy: {Toy}, candy: {Candy}, greeting: {Greeting}";
    }
}
