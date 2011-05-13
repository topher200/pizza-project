using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnderaPizzaCompany
{
    public class Pizza
    {
        public String name;
        public String base_toppings;
        public decimal cost;
        public List<string> toppings;

        public Pizza(String name, String base_toppings, decimal cost)
        {
            this.name = name;
            this.base_toppings = base_toppings;
            this.cost = cost;
            toppings = new List<string>();
        }

        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }
    }
}