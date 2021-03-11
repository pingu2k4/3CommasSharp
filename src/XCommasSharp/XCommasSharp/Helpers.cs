using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp
{
    public static class Helpers
    {
        public static decimal RoundToStepSize(decimal value, decimal stepSize, RoundMethod roundMethod = RoundMethod.Floor)
        {
            if(stepSize == 0)
            {
                throw new ArgumentException("Cannot divide by 0. Step size should be > 0.", nameof(stepSize));
            }

            switch (roundMethod)
            {
                case RoundMethod.Floor:
                    return Math.Floor(value / stepSize) * stepSize;
                case RoundMethod.Round:
                    return Math.Round(value / stepSize, 0, MidpointRounding.AwayFromZero) * stepSize;
                case RoundMethod.Ceiling:
                    return Math.Ceiling(value / stepSize) * stepSize;
                default:
                    throw new ArgumentException("Unexpected value", nameof(roundMethod));
            }
        }
    }
}
