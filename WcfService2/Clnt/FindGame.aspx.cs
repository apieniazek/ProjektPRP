using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class FindGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Service1Client sc = new Service1Client();
                ListItem li0 = new ListItem();
                li0.Value = "-1";
                li0.Text = "Wybierz:";
                ddlGatunek.Items.Add(li0);
                ddlProducent.Items.Add(li0);
                foreach (var item in sc.wyswietlProducentow())
                {
                    ListItem li = new ListItem();
                    li.Value = item.Id_producent.ToString();
                    li.Text = item.Nazwa.Trim();
                    ddlProducent.Items.Add(li);
                }
                foreach (var item in sc.wyswietlGatunki())
                {                    
                    ListItem li = new ListItem();
                    li.Value = item.Id_gatunek.ToString();
                    li.Text = item.Nazwa.Trim();
                    ddlGatunek.Items.Add(li);
                }
                sc.Close();
            }
        }

        protected void btnSzukaj_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(!tbTytul.Text.Equals(""))
            {
                i = 1;
            }
            if(ddlProducent.SelectedValue != "-1" )
            {
                i = 2;
            }
            if (!tbTytul.Text.Equals("") & ddlProducent.SelectedValue != "-1")
            {
                i = 3;
            }
            if (ddlGatunek.SelectedValue != "-1")
            {
                i = 4;
            }
            if (!tbTytul.Text.Equals("") & ddlGatunek.SelectedValue != "-1")
            {
                i = 5;
            }
            if (ddlProducent.SelectedValue != "-1" & ddlGatunek.SelectedValue != "-1")
            {
                i = 6;
            }
            if (!tbTytul.Text.Equals("") & ddlProducent.SelectedValue != "-1" & ddlGatunek.SelectedValue != "-1")
            {
                i = 7;
            }
            string url = string.Format("~/Default.aspx?i={0}&tytul={1}&prod={2}&gatunek={3}", i.ToString(), tbTytul.Text, ddlProducent.SelectedValue.ToString(), ddlGatunek.SelectedValue.ToString());
            Service1Client sc = new Service1Client();
            sc.wyswietlGry(i,tbTytul.Text,int.Parse(ddlProducent.SelectedValue),int.Parse(ddlGatunek.SelectedValue));
            sc.Close();
            Response.Redirect(url);
        }
    }
}