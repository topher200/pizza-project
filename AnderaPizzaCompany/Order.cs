using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnderaPizzaCompany
{
    public class Order
    {
        public int reference_number;
        public List<string> pizzas;

        public Order()
        {
            reference_number = 1337;
            pizzas = new List<string>();
        }

        public void AddPizza(String type)
        {
            pizzas.Add(type);
        }
    }
}