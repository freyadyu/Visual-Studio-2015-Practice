using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// where you write C# code corresponding to .aspx file
namespace WebApplicationPractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack) { // Post back happened in the event after first page loading
            Label1.Text = TextBox1.Text;
            }
        }

        protected void Single_Click(object sender, EventArgs e)
        {
           // Label1.Text = TextBox1.Text; //transfer textbox's content as label's text
        }
    }
}