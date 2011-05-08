using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnderaPizzaCompany
{
    public class Pizza
    {
        public List<string> toppings;
        private Pizza()
        {
            toppings = new List<string>();
        }

        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }
    }
}