using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWebApp
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        DataSetTableAdapters.TBL_OGRENCITableAdapter dt = new DataSetTableAdapters.TBL_OGRENCITableAdapter();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false) { 

            try {

            if (Request.QueryString["OGRID"] != null)
            {
                 id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
                TxtOgrID.Text = id.ToString();

               

             TxtOgrAd.Text=  dt.OgrenciSec(id)[0].OGRAD;  // hafızaya aldığı ilk değeri getir. formdan gelir.

                TxtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
                TxtOgrMail.Text = dt.OgrenciSec(id)[0].OGRMAIL;
                TxtOgrTelefon.Text = dt.OgrenciSec(id)[0].OGRTELEFON;

                TxtOgrSifre.Text = dt.OgrenciSec(id)[0].OGRSIFRE;

                TxtOgrFoto.Text = dt.OgrenciSec(id)[0].OGRFOTOGRAF;

                // Use id here
            }
            else
            {
                // Handle the case where "OGRID" is not present in the query string
            }
            }


            catch (Exception)
            {
                TxtOgrFoto.Text = "Link Girin.";
            }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTelefon.Text, TxtOgrMail.Text, TxtOgrSifre.Text, TxtOgrFoto.Text, Convert.ToInt32(TxtOgrID.Text));

            Response.Redirect("Default.aspx");



        }
    }
}