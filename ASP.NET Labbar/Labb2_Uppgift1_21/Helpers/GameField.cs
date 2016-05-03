using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb2_Uppgift1_21.Helpers
{
    public class GameField
    {
        public int Value { get; set; }
        public int PlusValue { get; set; }
        public string Active { get; set; }
        public string Color { get; set; }

        public GameField(int value, int plusValue, string active, string color)
        {
            Value = value;
            PlusValue = plusValue;
            Active = active;
            Color = color;
        }
    }
}