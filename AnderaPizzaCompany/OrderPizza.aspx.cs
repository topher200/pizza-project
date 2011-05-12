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
        }

        protected void OnCheckoutButton(Object s, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}