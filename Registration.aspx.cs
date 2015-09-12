using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Button_Click(object sender, EventArgs e)
    {
        Users s = new Users();

        s.Fname = fname.Text;
        s.Mname = mname.Text;
        s.Lname = lname.Text;
       // s.Dob = Calendar1.SelectedDate;
        s.Gender = int.Parse(DropDownList1.SelectedValue);
        s.A_line_1 = aline1.Text;
        s.A_line_2 = aline2.Text;
        s.A_line_3 = aline3.Text;
        s.Contact_no = Int32.Parse(contact.Text);

        //  s.Photo=FileUpload.

        if (FileUpload.FileName!=null)
        {
            HttpPostedFile myFile = FileUpload.PostedFile;
            int nFileLen = myFile.ContentLength;

            byte[] myData = new byte[nFileLen];
            myFile.InputStream.Read(myData, 0, nFileLen);

            Photo p = new Photo();
            p.WriteToFile(@"D:\" + milliseconds + "_image.jpg", myData);


        }
        else
        {
            // No file

        }

        s.Photo = @"D:\" + milliseconds + "_image.jpg";
        fname.Text = s.Photo;
        UserController uc = new UserController();

        fname.Text = uc.addUserdata(s);
    }
}