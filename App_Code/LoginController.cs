using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for LoginController
/// </summary>
public class LoginController
{
    DBHandler db;
    MySqlCommand cm;


    public LoginController()
    {
        db = new DBHandler();
        cm = new MySqlCommand();
    }

    public string addLogin(Login l)
    {

        cm.CommandText = "Insert into Login(email,password) values(@a,@b)";

        cm.Parameters.AddWithValue("a", l.Email);
        cm.Parameters.AddWithValue("b", l.Password);

        return db.InsertData(cm);

    }

    public int getLoginId(Login l) {

        cm.CommandText = "select idLogin from Login where email='"+l.Email+"'";

        DataTable dt = db.GetData(cm);
        Object ob = dt.Rows[0][0];
      
        int i = Convert.ToInt32(ob);

        return i;

    }

}