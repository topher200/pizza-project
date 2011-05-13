using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnderaPizzaCompany
{
    public partial class OrderComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Order order = (Order)Session["order"];
            if (order == null)
            {
                // How did we manage that?
                Response.Redirect("Default.aspx");
            }

            ReferenceNumberLabel.Text = "Reference number: #" + 
                order.GetReferenceNumber().ToString();
            TotalLabel.Text = "Total cost (including sales tax): " + 
                order.Cost().ToString("c");
        }

        protected void GoHome(Object s, EventArgs e)
        {
            Session["order"] = null;
            Response.Redirect("Default.aspx");
        }

        protected void OrderObject_ObjectCreating(object sender, 
            ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = (Order)Session["order"];
        }
    }
}