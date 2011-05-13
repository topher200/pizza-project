using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// OrderPizza is the main page of the ordering system.
// 
// From here, the user can add new pizzas to their order (-> AddPizza) or 
// complete their order and check out (-> Checkout).

namespace AnderaPizzaCompany
{
    public partial class OrderPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Start an order if we haven't already
            Order order = (Order)Session["order"];
            if (order == null)
            {
                // Figure out what reference number we should use
                Object last_ref = Application["last_reference_number"];
                int reference_number;
                if (last_ref == null)
                {
                    reference_number = 1;
                }
                else
                {
                    reference_number = (int) last_ref + 1;
                }
                Application["last_reference_number"] = reference_number;

                Session["order"] = new Order(reference_number);
            }
        }

        protected void PizzasGridView_RowCommand(
            object sender, GridViewCommandEventArgs e)
        {
            // TODO(topher): Instead of polling the asp fields, is there a 
            // better way we should be getting this data?
            DataKey pizza = PizzasGridView.DataKeys[
                Convert.ToInt32(e.CommandArgument)];
            string name = (string)pizza["name"];
            string base_toppings = (string)pizza["description"];
            decimal cost = (decimal)pizza["cost"];

            // TODO(topher): Is there a better way to pass a temporary object
            // to the next page? Should we be creating the Pizza on the next page?
            Session["pizza_to_add"] = new Pizza(name, base_toppings, cost);

            Response.Redirect("AddPizza.aspx");
        }

        protected void OnCheckoutButton(Object s, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }

        protected void Cancel(Object s, EventArgs e)
        {
            // Kick back out to main page
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