using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.ServiceReference1;

namespace Client
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Service1Client sc = new Service1Client();
                gvGry.DataSource = sc.wyswietlGry();
                gvGry.DataBind();
                sc.Close();
            }
        }
    }
}