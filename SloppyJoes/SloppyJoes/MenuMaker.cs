using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoes
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = {"Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayo", "Relish", "French Dressing"};
        string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "Italian Bread", "A roll" };
        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}
