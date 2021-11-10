using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNicolasPresents
{
    interface IPresentBuilder
    {
        void Reset();

        void SetToy(string toy);

        void SetCandy(string candy);

        void SetGreeting(string greeting);
    }
}
