using System.Collections.Generic;

namespace StNicolasPresents
{
    abstract class BuildingStrategy : IPresentMakingStrategy
    {
        protected IPresentBuilder _builder;
        protected IEnumerable<string> _boyToys;
        protected IEnumerable<string> _girlToys;
        protected IEnumerable<string> _candies;
        protected IEnumerable<string> _greetings;

        protected BuildingStrategy(
            IPresentBuilder builder,
            IEnumerable<string> boyToys,
            IEnumerable<string> girlToys,
            IEnumerable<string> candies,
            IEnumerable<string> greetings
            )
        {
            _builder = builder;
            _boyToys = boyToys;
            _girlToys = girlToys;
            _candies = candies;
            _greetings = greetings;
        }

        public abstract void MakePresent(Child child);
    }
}
