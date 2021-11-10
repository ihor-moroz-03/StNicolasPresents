namespace StNicolasPresents
{
    sealed class PresentBuilder : IPresentBuilder
    {
        public static readonly PresentBuilder Instance;
        Present _result;

        static PresentBuilder()
        {
            Instance = new();
        }

        PresentBuilder()
        {
        }

        public Present Result { get => _result; }

        public void Reset() => _result = new();

        public void SetToy(string toy) => _result.Toy = toy;

        public void SetCandy(string candy) => _result.Candy = candy;

        public void SetGreeting(string greeting) => _result.Greeting = greeting;
    }
}
