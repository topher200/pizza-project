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
            XDocument xml = new XDocument(
                new XElement("Pizza1")
                );
            // TODO(topher): where should this file be saved?
            using (System.IO.FileStream fs = 
                System.IO.File.Create(@"C:\Users\topher\Documents\asdf.txt"))
            {
                xml.Save(fs);
            }
        }
    }
}