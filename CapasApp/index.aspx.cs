using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AppNegocio;


namespace CapasApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_calcular_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(this.Txt_x.Text);

            AppNegocio.Negocio Negocio = new AppNegocio.Negocio();

            double y = Negocio.CalcularY(x);
           

            this.Txt_y.Text = y.ToString();
        }
    }
}