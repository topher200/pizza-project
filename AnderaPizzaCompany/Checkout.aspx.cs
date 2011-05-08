using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnderaPizzaCompany
{
    public partial class Checkout : System.Web.UI.Page
    {
        private Order order;

        protected void Page_Load(object sender, EventArgs e)
        {
            order = (Order)Session["order"];
        }

        protected void OnSubmitButton(Object s, EventArgs e)
        {
        }
    }
}