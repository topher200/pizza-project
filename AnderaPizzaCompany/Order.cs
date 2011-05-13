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

        public Order()
        {
            reference_number = 1337;
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
                    p.Cost());
            }

            return table;
        }

        public int GetReferenceNumber()
        {
            return reference_number;
        }

        public decimal Cost()
        {
            decimal cost = 0;
            foreach (Pizza p in pizzas)
            {
                cost += p.Cost();
            }
            return cost;
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
    }
}