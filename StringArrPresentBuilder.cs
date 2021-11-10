using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNicolasPresents
{
    sealed class StringArrPresentBuilder : IPresentBuilder
    {
        public static readonly StringArrPresentBuilder Instance;
        string[] _result;

        static StringArrPresentBuilder()
        {
            Instance = new();
        }

        StringArrPresentBuilder()
        {
        }

        public string[] Result { get => _result; }

        public void Reset() => _result = new string[3];

        public void SetToy(string toy) => _result[0] = toy;

        public void SetCandy(string candy) => _result[1] = candy;

        public void SetGreeting(string greeting) => _result[2] = greeting;
    }
}
