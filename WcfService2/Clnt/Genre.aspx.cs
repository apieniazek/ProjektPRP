using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class Genre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Service1Client sc = new Service1Client();
                gvGatunek.DataSource = sc.wyswietlGatunki();
                gvGatunek.DataBind();
                sc.Close();
            }
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddGenre.aspx");
        }
    }
}