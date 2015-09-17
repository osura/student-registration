using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;//to rename images and make it unique

    protected void Page_Load(object sender, EventArgs e)
    {

        //----------------------DOB-----------------------------
        if (!IsPostBack)
        {
            if (this.SelectedDate == DateTime.MinValue)
            {
                this.PopulateYear();
                this.PopulateMonth();
                this.PopulateDay();
            }
        }
        else
        {
            if (Request.Form[ddlDay.UniqueID] != null)
            {
                this.PopulateDay();
                ddlDay.ClearSelection();
                ddlDay.Items.FindByValue(Request.Form[ddlDay.UniqueID]).Selected = true;
            }
        }
        //---------------------------------------------------------------------------
    }
    protected void Submit_Button_Click(object sender, EventArgs e)
    {
        Users s = new Users();

        Login l = new Login();
        l.Email = email.Text;
        l.Password = password.Text;

        LoginController lc = new LoginController();
        lc.addLogin(l);
        s.Login_idLogin1 = lc.getLoginId(l);

        
       
        
        
        

        s.Fname = fname.Text;
        s.Mname = mname.Text;
        s.Lname = lname.Text;
        s.Dob = this.SelectedDate;
        s.Gender = int.Parse(DropDownList1.SelectedValue);
        s.A_line_1 = aline1.Text;
        s.A_line_2 = aline2.Text;
        s.A_line_3 = aline3.Text;
        s.Contact_no = Int32.Parse(contact.Text);


        //  s.Photo=FileUpload.

        if (FileUpload.FileName != null)
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






    //-------------------dob-----------------------------------------------
    //--------------------set and get date--------------------------------------------------



    private int Day
    {
        get
        {
            if (Request.Form[ddlDay.UniqueID] != null)
            {
                return int.Parse(Request.Form[ddlDay.UniqueID]);
            }
            else
            {
                return int.Parse(ddlDay.SelectedItem.Value);
            }
        }
        set
        {
            this.PopulateDay();
            ddlDay.ClearSelection();
            ddlDay.Items.FindByValue(value.ToString()).Selected = true;
        }
    }
    private int Month
    {
        get
        {
            return int.Parse(ddlMonth.SelectedItem.Value);
        }
        set
        {
            this.PopulateMonth();
            ddlMonth.ClearSelection();
            ddlMonth.Items.FindByValue(value.ToString()).Selected = true;
        }
    }
    private int Year
    {
        get
        {
            return int.Parse(ddlYear.SelectedItem.Value);
        }
        set
        {
            this.PopulateYear();
            ddlYear.ClearSelection();
            ddlYear.Items.FindByValue(value.ToString()).Selected = true;
        }
    }

    public DateTime SelectedDate
    {
        get
        {
            try
            {
                return DateTime.Parse(this.Month + "/" + this.Day + "/" + this.Year);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
        set
        {
            if (!value.Equals(DateTime.MinValue))
            {
                this.Year = value.Year;
                this.Month = value.Month;
                this.Day = value.Day;
            }
        }
    }


    //-----------------------------------------------------------------------------


    private void PopulateDay()
    {
        ddlDay.Items.Clear();
        ListItem lt = new ListItem();
       
        
        int days = DateTime.DaysInMonth(this.Year, this.Month);
        for (int i = 1; i <= days; i++)
        {
            lt = new ListItem();
            lt.Text = i.ToString();
            lt.Value = i.ToString();
            ddlDay.Items.Add(lt);
        }
        ddlDay.Items.FindByValue(DateTime.Now.Day.ToString()).Selected = true;
    }

    private void PopulateMonth()
    {
        ddlMonth.Items.Clear();
        ListItem lt = new ListItem();
        
        for (int i = 1; i <= 12; i++)
        {
            lt = new ListItem();
            lt.Text = Convert.ToDateTime(i.ToString() + "/1/1900").ToString("MMMM");
            lt.Value = i.ToString();
            ddlMonth.Items.Add(lt);
        }
        ddlMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
    }

    private void PopulateYear()
    {
        ddlYear.Items.Clear();
        ListItem lt = new ListItem();
        
        for (int i = DateTime.Now.Year; i >= 1950; i--)
        {
            lt = new ListItem();
            lt.Text = i.ToString();
            lt.Value = i.ToString();
            ddlYear.Items.Add(lt);
        }
        ddlYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
    }


    //-------------------------------------------------------------------------------------




}



