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
                bool broccoli = checkbox_broccoli.Checked;

                String pizza_type = Request.QueryString["pizza"];
                order.AddPizza(pizza_type);

                // After adding a pizza, go back to the order page
                Session["order"] = order;
            }

            Response.Redirect("OrderPizza.aspx");
        }
    }
}