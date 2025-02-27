using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp1_5826347
{
    public partial class Ejemplo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Confir_Click(object sender, EventArgs e)
        {
            //Sava the session variables.
            Session["ddlCategory"] = ddlCategory.SelectedValue;
            Session["ddlSupplier"] = ddlSupplier.SelectedValue;
            Session["txtProduct"] = txtProduct.Text;
            Session["txtDescription"] = txtDescription.Text;
            Session["txtImage"] = txtImage.Text;
            Session["txtPrice"] = txtPrice.Text;
            Session["txtNumberInStock"] = txtNumberInStock.Text;
            Session["txtNumberOnOrder"] = txtNumberOnOrder.Text;
            Session["txtReorderLevel"] = txtReorderLevel.Text;
            //Go to the confirmation page.
            Response.Redirect("Mostrar.aspx");
        }
    }
}