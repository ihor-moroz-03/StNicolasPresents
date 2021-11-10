using System;

namespace StNicolasPresents
{
    class Program
    {
        static void Main()
        {
            string[]
                boyToys = new[] { "Car", "Tool", "Gun" },
                girlToys = new[] { "Doll", "Drawing" },
                candies = new[] { "Chocolate", "Chupa Chups" },
                greetings = new[] { "Wishing you a very Happy St. Nicholas Day..." };

            Child[] children = new Child[]
            {
                new("Allie", Sex.Female, 10, 3),
                new("Jack", Sex.Male, 6, 8)
            };

            StNicolas nicolas = new(new LitePresentMakingStrategy(PresentBuilder.Instance, boyToys, girlToys, candies, greetings));
            nicolas.MakePresent(children[0]);
            Console.WriteLine(PresentBuilder.Instance.Result);

            nicolas.MakePresent(children[1]);
            Console.WriteLine(PresentBuilder.Instance.Result);

            nicolas.SetStrategy(new StrictPresentMakingStrategy(StringArrPresentBuilder.Instance, boyToys, girlToys, candies, greetings));
            nicolas.MakePresent(children[0]);
            WriteStringArr(StringArrPresentBuilder.Instance.Result);

            nicolas.MakePresent(children[1]);
            WriteStringArr(StringArrPresentBuilder.Instance.Result);

            Console.Read();
        }

        static void WriteStringArr(string[] arr)
        {
            foreach (string str in arr)
            {
                Console.Write(str);
                Console.Write(" - ");
            }
            Console.WriteLine();
        }
    }
}
