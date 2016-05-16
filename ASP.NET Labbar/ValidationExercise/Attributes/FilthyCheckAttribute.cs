using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationExercise.Attributes
{
    public class FilthyCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var ToCheck = value.ToString().ToLower();
            return !ToCheck.Contains("porn") &&
                   !ToCheck.Contains("sex") && !ToCheck.Contains("margaret thatcher");
        }

        public override string FormatErrorMessage(string field)
        {
            return field + " please don't write any filthy words";
        }
    }
}