using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            double a = 2;
            double b = 2;
            double c = 2;


            double y = 0;

            //y = (a)x^2 + b(x) + c 

            y = ((a) * (Math.Pow(x, 2))) + (b * x) + c;

            this.Txt_y.Text = y.ToString();
        }
    }
}