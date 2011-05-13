using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AnderaPizzaCompany
{
    public class Order
    {
        private int reference_number;
        public List<Pizza> pizzas;

        public Order(int reference_number)
        {
            this.reference_number = reference_number;
            pizzas = new List<Pizza>();
        }

        public DataTable GetPizzaDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Pizza");
            table.Columns.Add("Description");
            table.Columns.Add("Extra Toppings");
            table.Columns.Add("Cost");

            foreach (Pizza p in pizzas)
            {
                table.Rows.Add(p.name, p.base_toppings, p.ListToppings(), 
                    p.Cost().ToString("c"));
            }

            return table;
        }

        public int GetReferenceNumber()
        {
            return reference_number;
        }

        // Cost is the cost of each pizza + 7% sales tax
        public decimal Cost()
        {
            decimal cost = 0;
            foreach (Pizza p in pizzas)
            {
                cost += p.Cost();
            }
            cost += cost * Convert.ToDecimal(0.07); // Tax
            return cost;
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
    }
}