using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// AddPizza allows the customer to add extra toppings to their Pizza.
//
// This page can only be reached by OrderPizza, and only returns to there.
//
// After choosing the "base" type of pizza, customers use this page to customize
// their pizza with extra toppings and finally add it to their order.

namespace AnderaPizzaCompany
{
    public partial class AddPizza : System.Web.UI.Page
    {
        private Pizza pizza_to_add;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Check the Session variables to make sure we have started an order
            // and chose a pizza to add
            Order order = (Order)Session["order"];
            pizza_to_add = (Pizza)Session["pizza_to_add"];
            if ((order == null) || (pizza_to_add == null)) {
                Response.Redirect("OrderPizza.aspx");
            }

            // Display the base description of the pizza
            PizzaLabel.Text = pizza_to_add.name + "; includes " +
                pizza_to_add.base_toppings + ". Starts at " + 
                pizza_to_add.base_cost.ToString("c");
        }

        protected void Submit(object sender, EventArgs e)
        {
            Order order = (Order)Session["order"];

            if (order != null)
            {
                // Add checked toppings to the pizza
                foreach (GridViewRow row in ToppingsGridView.Rows)
                {
                    CheckBox cb = (CheckBox)row.FindControl("ToppingSelector");
                    if ((cb != null) && (cb.Checked))
                    {
                        DataKey topping_key = 
                            ToppingsGridView.DataKeys[row.RowIndex];
                        string name = (string) topping_key["topping"];
                        decimal cost = (decimal) topping_key["cost"];
                        Topping topping = new Topping(name, cost);
                        pizza_to_add.AddTopping(topping);
                    }
                }

                // Add the pizza to the order, and go back to the order page
                order.AddPizza(pizza_to_add);
                Session["order"] = order;
            }

            Session["pizza_to_add"] = null;
            Response.Redirect("OrderPizza.aspx");
        }

        protected void Cancel(object sender, EventArgs e)
        {
            Session["pizza_to_add"] = null;
            Response.Redirect("OrderPizza.aspx");
        }
    }
}