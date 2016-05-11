using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Retro
{
    public class SekvensBoxar
    {
        public double Square(int number1)
        {
            var result = Math.Pow(number1, 2);
            return result;
            //return -1;
        }
        public double Salary(int salary)
        {
            var result = (salary*1.09 + 15000);
            return result;
            throw new NotImplementedException();
        }

        public void TimeCount(int hours, out int resultMinutes, out int resultSeconds)
        {
            resultMinutes = (hours * 60);
            resultSeconds = (resultMinutes * 60);
        }

        public void SumNumbers(int number1, int number2, int number3, out int resultSum, out double resultMedian)
        {
            resultSum = (number1 + number2 + number3);
            resultMedian = (resultSum/3);
        }

        public void Currency(int number, out double dollarCurrency, out double poundCurrency)
        {
            dollarCurrency = (number*6);
            poundCurrency = (number*12);
        }

}
}
