using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_3_konvertera_temperaturer.Model
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int degreesC)
        {
            int farenheit = (int)Math.Round(degreesC * 1.8 + 32);

            return farenheit;
        }

        public static int FahrenheitToCelsius(int degreesF)
        {
            int celcius = (int)Math.Round((degreesF - 32) * 5d / 9);

            return celcius;
        }
    }
} 