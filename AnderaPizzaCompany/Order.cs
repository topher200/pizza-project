using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnderaPizzaCompany
{
    public class Order
    {
        private int reference_number;
        public List<Pizza> pizzas;

        public Order()
        {
            reference_number = 1337;
            pizzas = new List<Pizza>();
        }

        public int GetReferenceNumber()
        {
            return reference_number;
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
    }
}