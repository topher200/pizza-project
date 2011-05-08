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

            if (order != null)
            {
                int reference = order.reference_number;
            }

            Session["order"] = order;
        }
    }
}