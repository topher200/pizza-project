using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace AnderaPizzaCompany
{
    public partial class Checkout : System.Web.UI.Page
    {
        private Order order;

        protected void Page_Load(object sender, EventArgs e)
        {
            order = (Order)Session["order"];
            if (order == null)
            {
                // We can't checkout if we haven't started an order yet
                Response.Redirect("OrderPizza.aspx");
            }
        }

        protected void OnSubmitButton(Object s, EventArgs e)
        {
            // TODO(topher): where should this file be saved?
            string output_filename = @"C:\Users\topher\Documents\order_" + 
                order.GetReferenceNumber() + ".xml";
            order.GetPizzaDataTable().WriteXml(output_filename);
        }
    }
}