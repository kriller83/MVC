using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_The_String_Calculator_Kata
{
    public class String_Calculator
    {
        public int Add(string one, string two)
        {
            var result = (one + two);
            return Convert.ToInt32(result);
            throw new NotImplementedException();
        }
        //public int Add(string one)
        //{
        //    var result = one;
        //    return Convert.ToInt32(result);
        //    throw new NotImplementedException();
        //}
    }
}
