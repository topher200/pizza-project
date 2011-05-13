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
        public List<Topping> toppings;

        public Pizza(String name, String base_toppings, decimal cost)
        {
            this.name = name;
            this.base_toppings = base_toppings;
            this.cost = cost;
            toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }
    }
}