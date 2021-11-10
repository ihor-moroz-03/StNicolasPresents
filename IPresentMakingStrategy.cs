using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNicolasPresents
{
    interface IPresentMakingStrategy
    {
        void MakePresent(Child child);
    }
}
