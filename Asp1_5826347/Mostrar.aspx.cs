using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp1_5826347
{
    public partial class Mostrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSupplier.Enabled = false;
            ddlCategory.Enabled = false;
            txtDescription.Enabled = false;
            //Retrieve the cookies.
            ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
            ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
            txtProduct.Text = Session["txtProduct"].ToString();
            txtDescription.Text = Session["txtDescription"].ToString();
            txtImage.Text = Session["txtImage"].ToString();
            Decimal decPrice = Convert.ToDecimal(Session["txtPrice"]);
            txtPrice.Text = decPrice.ToString("c");
            txtNumberInStock.Text = Session["txtNumberInStock"].ToString();
            txtNumberOnOrder.Text = Session["txtNumberOnOrder"].ToString();
            txtReorderLevel.Text = Session["txtReorderLevel"].ToString();
            //compute and display the value in stock and the value on order.
            Byte bytNumberInStock = Convert.ToByte(Session["txtNumberInStock"]);
            Byte bytNumberOnOrder = Convert.ToByte(Session["txtNumberOnOrder"]);
            Decimal decValueInStock = decPrice * bytNumberInStock;
            Decimal decValueOnOrder = decPrice * bytNumberOnOrder;
            txtNumberInStock.Text = decValueInStock.ToString("c");
            txtNumberOnOrder.Text = decValueOnOrder.ToString("c");
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {

        }

        protected void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}