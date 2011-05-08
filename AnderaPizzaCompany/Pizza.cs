using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnderaPizzaCompany
{
    public class Pizza
    {
        public List<string> toppings;
        public String type;

        public Pizza(String type_)
        {
            type = type_;
            toppings = new List<string>();
        }

        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }
    }
}