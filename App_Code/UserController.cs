using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for UserController
/// </summary>
public class UserController
{
    DBHandler db;
    MySqlCommand cm;

    public UserController()
    {
        db = new DBHandler();
        cm = new MySqlCommand();
    }

    public string addUserdata(Users s)
    {



        cm.CommandText = "INSERT INTO users(First_Name,Middle_Name,Last_Name,DOB,Gender_idGender,Address_Line1,Address_Line2,Address_Line3,Contact_No,Photo,nsbmid,status,Login_idLogin,User_type_idUser_type) Values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n)";

        //cm.CommandText = "Insert into users values('1','fname','mname','lname','2012-12-3','1','adl1','adl2','adl3','23423','photo','ns1','1','1','1')";

        

        cm.Parameters.AddWithValue("a", s.Fname);
        cm.Parameters.AddWithValue("b", s.Mname);
        cm.Parameters.AddWithValue("c", s.Lname);
        cm.Parameters.AddWithValue("d", s.Dob);
        cm.Parameters.AddWithValue("e", s.Gender);
        cm.Parameters.AddWithValue("f", s.A_line_1);
        cm.Parameters.AddWithValue("g", s.A_line_2);
        cm.Parameters.AddWithValue("h", s.A_line_3);
        cm.Parameters.AddWithValue("i", s.Contact_no);
        cm.Parameters.AddWithValue("j", s.Photo);
        cm.Parameters.AddWithValue("k", s.Nsbmid);
        cm.Parameters.AddWithValue("l", s.Status);
        cm.Parameters.AddWithValue("m", s.Login_idLogin1);
        cm.Parameters.AddWithValue("n", s.User_type_idUser_type1);


        return db.InsertData(cm);


    }
}