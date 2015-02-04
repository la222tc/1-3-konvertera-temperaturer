﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_3_konvertera_temperaturer.Model
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int degreesC)
        {
            return  (int)Math.Round(degreesC * 1.8 + 32);
        }

        public static int FahrenheitToCelsius(int degreesF)
        {
            return (int)Math.Round((degreesF - 32) * 5d / 9);
        }
    }
} 