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
        private Pizza pizza_to_add;

        protected void Page_Load(object sender, EventArgs e)
        {
            Order order = (Order)Session["order"];
            pizza_to_add = (Pizza)Session["pizza_to_add"];
            if ((order == null) || (pizza_to_add == null)) {
                // We can't add a pizza if we haven't started an order or chosen 
                // the pizza
                Response.Redirect("OrderPizza.aspx");
            }
            Session["pizza_to_add"] = null;
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

            Response.Redirect("OrderPizza.aspx");
        }
    }
}