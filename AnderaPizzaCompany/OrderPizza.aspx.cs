using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnderaPizzaCompany
{
    public partial class OrderPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Order order = (Order)Session["order"];
            if (order == null)
            {
                order = new Order();
            }

            if (order.pizzas.Count > 0)
            {
                // label_pizza0.Text = order.pizzas[0];
            }

            Session["order"] = order;
        }

        protected void Click(Object s, EventArgs e)
        {
            Response.Redirect("AddPizza.aspx?pizza=cheese");
        }

        protected void PizzasGridView_RowCommand(
            object sender, GridViewCommandEventArgs e)
        {
            // TODO(topher): Instead of polling the asp fields, is there a 
            // better way we should be getting this data?
            DataKey pizza = PizzasGridView.DataKeys[
                Convert.ToInt32(e.CommandArgument)];
            string name = (string)pizza["name"];
            string base_toppings = (string)pizza["description"];
            decimal cost = (decimal)pizza["cost"];

            // TODO(topher): Is there a better way to pass a temporary object
            // to the next page? Should we be creating the Pizza on the next page?
            Session["pizza_to_add"] = new Pizza(name, base_toppings, cost);

            Response.Redirect("AddPizza.aspx");
        }

        protected void OnCheckoutButton(Object s, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}