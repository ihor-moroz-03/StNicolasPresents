namespace StNicolasPresents
{
    class StNicolas
    {
        IPresentMakingStrategy _strategy;

        public StNicolas(IPresentMakingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void MakePresent(Child child) => _strategy.MakePresent(child);

        public void SetStrategy(IPresentMakingStrategy strategy)
            => _strategy = strategy;
    }
}
