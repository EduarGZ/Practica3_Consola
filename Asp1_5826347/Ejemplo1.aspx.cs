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
            //Save the cookies
            Response.Cookies["ddlCategory"].Value = ddlCategory.SelectedValue;
            Response.Cookies["ddlSupplier"].Value = ddlSupplier.SelectedValue;
            Response.Cookies["txtProduct"].Value = txtProduct.Text;
            Response.Cookies["txtDescription"].Value = txtDescription.Text;
            Response.Cookies["txtImage"].Value = txtImage.Text;
            Response.Cookies["txtPrice"].Value = txtPrice.Text;
            Response.Cookies["txtNumberInStock"].Value = txtNumberInStock.Text;
            Response.Cookies["txtNumberOnOrder"].Value = txtNumberOnOrder.Text;
            Response.Cookies["txtReorderLevel"].Value = txtReorderLevel.Text;
            //Go to the confirmation page.
            Response.Redirect("Mostrar.aspx");
        }
    }
}