using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    public class MyRandom
    {
        string[] mock = new string[] { "ABC" };
        public string Next()
        {
            return mock[0];
        }
    }
}
