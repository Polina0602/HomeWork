using ConsoleApp5.drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Flat
    {
        public IDrink _Drink;
        public Flat(IDrink drinkType)
        {
            _Drink = drinkType; 
        }
    }
}
