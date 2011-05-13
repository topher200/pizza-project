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
                new XElement("order",
                    new XElement("reference_number", order.GetReferenceNumber().ToString()),
                    new XElement("pizzas",
                        order.pizzas.Select(pizza => new XElement("pizza", 
                            new XElement("name", pizza.name),
                            new XElement("base_toppings", pizza.base_toppings),
                            pizza.toppings.Select(topping => 
                                new XElement("extra_topping", topping.name)),
                            new XElement("cost", pizza.Cost())))),
                    new XElement("total_price", order.Cost())));

            // TODO(topher): where should this file be saved?
            string output_filename = @"C:\Users\topher\Documents\order_" + 
                order.GetReferenceNumber() + ".xml";
            using (System.IO.FileStream fs = 
                System.IO.File.Create(output_filename))
            {
                xml.Save(fs);
            }
        }

        protected void OrderObject_ObjectCreating(object sender, 
            ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = (Order)Session["order"];
        }
    }
}