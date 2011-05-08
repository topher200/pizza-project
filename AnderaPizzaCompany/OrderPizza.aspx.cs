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

            pizzas_label.Text = "";
            foreach (string pizza in order.pizzas)
            {
                pizzas_label.Text += "asdf";
            }

            Session["order"] = order;
        }

        protected void Click(Object s, EventArgs e)
        {
            Response.Redirect("AddPizza.aspx?pizza=cheese");
        }
    }
}