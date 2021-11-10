using System.Collections.Generic;
using static Algorithms.Enumeration;

namespace StNicolasPresents
{
    class LitePresentMakingStrategy : BuildingStrategy
    {
        IEnumerator<string> _boyToysEnum, _girlToysEnum, _candiesEnum, _greetingsEnum;

        public LitePresentMakingStrategy(
            IPresentBuilder builder,
            IEnumerable<string> boyToys,
            IEnumerable<string> girlToys,
            IEnumerable<string> candies,
            IEnumerable<string> greetings
            )
            : base(builder, boyToys, girlToys, candies, greetings)
        {
            _boyToysEnum = _boyToys.GetEnumerator();
            _girlToysEnum = _girlToys.GetEnumerator();
            _candiesEnum = _candies.GetEnumerator();
            _greetingsEnum = _greetings.GetEnumerator();
        }

        public override void MakePresent(Child child)
        {
            _builder.Reset();
            switch (child.Sex)
            {
                case Sex.Male: _builder.SetToy(_boyToysEnum.CycleNext()); break;
                case Sex.Female: _builder.SetToy(_girlToysEnum.CycleNext()); break;
            }
            _builder.SetCandy(_candiesEnum.CycleNext());
            _builder.SetGreeting(_greetingsEnum.CycleNext());
        }
    }
}
