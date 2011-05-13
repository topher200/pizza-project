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
        public decimal base_cost;
        public List<Topping> toppings;

        public Pizza(String name, String base_toppings, decimal base_cost)
        {
            this.name = name;
            this.base_toppings = base_toppings;
            this.base_cost = base_cost;
            toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }

        // Returns a string listing the toppings, comma-separated.
        public string ListToppings()
        {
            string toppings_string = "";
            for (int i = 0; i < toppings.Count(); i++)
            {
                if (i != 0)
                {
                    // No comma first time though
                    toppings_string += ", ";
                }
                toppings_string += toppings[i].name;
            }
            return toppings_string;
        }

        // Cost is the base cost + the cost of each extra topping
        public decimal Cost()
        {
            decimal cost = this.base_cost;
            foreach (Topping t in toppings)
            {
                cost += t.cost;
            }
            return cost;
        }
    }
}