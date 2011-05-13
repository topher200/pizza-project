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