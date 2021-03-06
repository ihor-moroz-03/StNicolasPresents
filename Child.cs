namespace StNicolasPresents
{
    readonly struct Child
    {
        public readonly string Name;
        public readonly Sex Sex;
        public readonly int GoodDeeds, BadDeeds;

        public Child(string name, Sex sex, int goodDeeds, int badDeeds)
        {
            Name = name; Sex = sex; GoodDeeds = goodDeeds; BadDeeds = badDeeds;
        }
    }

    enum Sex { Male, Female }
}
