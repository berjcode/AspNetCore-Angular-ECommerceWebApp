using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWebApp
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblmessage.Text += "Page load event handled. <br />";
        }

        //protected void btnclick_Click(object sender, EventArgs e)
        //{
        //    //if (Page.IsPostBack)
        //    //{
        //    //    lblmessage.Text += "Page post back event handled.<br/>";
        //    //}
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
   //         if (!String.IsNullOrEmpty(TextBox1.Text))
   //         {

   //             // Access the HttpServerUtility methods through
   //             // the intrinsic Server object.
   //             Label1.Text = "Welcome, " + Server.HtmlEncode(TextBox1.Text) + ". <br/> The url is " + Server.UrlEncode(Request.Url.ToString());
   //}
        }
    }
}

//Ardından kullanıcı bir butona tıklayarak veya benzeri bir olay gerçekleştirerek işlem yapmak isterse, sayfa tekrar sunucuya gönderilir. 

//İşlemlerin yapılması için sayfanın sunucuya geri gönderilmesine postback işlemi denir.

//Bazı durumlarda sayfanın ilk kez mi çağrıldığı yoksa sunucuya geri mi gönderildiğin