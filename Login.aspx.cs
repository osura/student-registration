using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Sign_in_Button_Click(object sender, EventArgs e)
    {
        Login lg = new Login();

        lg.Email= login_email.Text;
        lg.Password= login_password.Text;

        LoginController lc = new LoginController();

        if(lc.checkLogin(lg)==1){

            warning.Text = "sucess";
        }
        if(lc.checkLogin(lg)>1){
            warning.Text = "multiple User Accounts from one email";
        }
        if(lc.checkLogin(lg)<1){
            warning.Text = "Username or Password doesn't match";
        }


    }
}