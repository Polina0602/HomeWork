﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.drinks
{
    internal class Water : IDrink
    {
        public string GetDrink()
        {
            return "water";
        }
    }
}