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
                // TODO(topher)
            }
            else
            {
                // We don't know what kind of pizza this is
                Response.Redirect("OrderPizza.aspx");
            }
        }
    }
}