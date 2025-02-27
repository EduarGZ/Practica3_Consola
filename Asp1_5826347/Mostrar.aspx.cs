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
            ddlCategory.SelectedValue = Request.QueryString["ddlCategory"];
            ddlSupplier.SelectedValue = Request.QueryString["ddlSupplier"];
            txtProduct.Text = Request.QueryString["txtProduct"];
            txtDescription.Text = Request.QueryString["txtDescription"];
            txtImage.Text = Request.QueryString["txtImage"];
            Decimal decPrice = Convert.ToDecimal(Request.QueryString["txtPrice"]);
            txtPrice.Text = decPrice.ToString("c");
            txtNumberInStock.Text = Request.QueryString["txtNumberInStock"];
            txtNumberOnOrder.Text = Request.QueryString["txtNumberOnOrder"];
            txtReorderLevel.Text = Request.QueryString["txtReorderLevel"];
            //compute and display the value in stock and the value on order.
            Byte bytNumberInStock = Convert.ToByte(Request.QueryString["txtNumberInStock"]);
            Byte bytNumberOnOrder = Convert.ToByte(Request.QueryString["txtNumberOnOrder"]);
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