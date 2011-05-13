using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnderaPizzaCompany
{
    public class Topping
    {
        public string name;
        public decimal cost;

        public Topping(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}