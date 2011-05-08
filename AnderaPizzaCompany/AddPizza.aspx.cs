using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnderaPizzaCompany
{
    public partial class AddPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit(object sender, EventArgs e)
        {
            Order order = (Order)Session["order"];

            if (order != null)
            {
                // Create a new pizza of the given type
                String pizza_type = Request.QueryString["pizza"];
                Pizza pizza = new Pizza(pizza_type);

                // Add checked toppings to the pizza
                if (checkbox_broccoli.Checked)
                {
                    pizza.AddTopping("broccoli");
                }

                // Add the pizza to the order, and go back to the order page
                order.AddPizza(pizza);
                Session["order"] = order;
            }

            Response.Redirect("OrderPizza.aspx");
        }
    }
}