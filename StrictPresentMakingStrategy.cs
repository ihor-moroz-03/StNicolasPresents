using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNicolasPresents
{
    class StrictPresentMakingStrategy : BuildingStrategy
    {
        Random _rd;
        int _boyToysCount, _girlToysCount, _candiesCount, _greetingsCount;

        public StrictPresentMakingStrategy(
            IPresentBuilder builder,
            IEnumerable<string> boyToys,
            IEnumerable<string> girlToys,
            IEnumerable<string> candies,
            IEnumerable<string> greetings
            )
            : base(builder, boyToys, girlToys, candies, greetings)
        {
            _rd = new();
            _boyToysCount = _boyToys.Count();
            _girlToysCount = _girlToys.Count();
            _candiesCount = _candies.Count();
            _greetingsCount = _greetings.Count();
        }

        public override void MakePresent(Child child)
        {
            _builder.Reset();
            if (child.GoodDeeds > child.BadDeeds)
            {
                switch (child.Sex)
                {
                    case Sex.Male: _builder.SetToy(_boyToys.ElementAt(_rd.Next(_boyToysCount))); break;
                    case Sex.Female: _builder.SetToy(_girlToys.ElementAt(_rd.Next(_girlToysCount))); break;
                }
                _builder.SetCandy(_candies.ElementAt(_rd.Next(_candiesCount)));
                _builder.SetGreeting(_greetings.ElementAt(_rd.Next(_greetingsCount)));
            }
            else
            {
                _builder.SetToy("Birch");
                _builder.SetGreeting("Be better-behaving");
            }
        }
    }
}
