using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StudentRegisteration
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("BasicHttpBinding_IStudentService");
            StudentService.Student student = new StudentService.Student();
            student.StudID = System.Convert.ToInt32(txtStudID.Text);
            student.StudName = txtName.Text;
            student.StudGender = txtGender.Text;
            client.insertData(student);
        }
    }
}