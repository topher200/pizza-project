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
            String pizza_type = Request.QueryString["pizza"];
            if (pizza_type == "cheese")
            {
                Order order = new Order();
                Session["order"] = order;
            }
            else
            {
                // We don't know what kind of pizza this is
            }

            // After [possibly] adding a pizza, go back to the order page
            Response.Redirect("OrderPizza.aspx");
        }
    }
}