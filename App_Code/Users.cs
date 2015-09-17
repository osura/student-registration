using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for Student
/// </summary>
public class Users
{
    String sid;
    String fname;
    String mname;
    String lname;
    DateTime dob;
    int gender;
    String a_line_1;
    String a_line_2;
    String a_line_3;
    int contact_no;
    String photo;
    String nsbmid="not set";
    int status=0;
    int Login_idLogin;
    int User_type_idUser_type=3;

    

    public String Sid
    {
        get { return sid; }
        set { sid = value; }
    }


    public String Fname
    {
        get { return fname; }
        set { fname = value; }
    }


    public String Mname
    {
        get { return mname; }
        set { mname = value; }
    }


    public String Lname
    {
        get { return lname; }
        set { lname = value; }
    }

    public DateTime Dob
    {
        get { return dob; }
        set { dob = value; }
    }

    public int Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public String A_line_1
    {
        get { return a_line_1; }
        set { a_line_1 = value; }
    }


    public String A_line_2
    {
        get { return a_line_2; }
        set { a_line_2 = value; }
    }


    public String A_line_3
    {
        get { return a_line_3; }
        set { a_line_3 = value; }
    }


    public int Contact_no
    {
        get { return contact_no; }
        set { contact_no = value; }
    }


    public String Photo
    {
        get { return photo; }
        set { photo = value; }
    }

    public String Nsbmid
    {
        get { return nsbmid; }
        set { nsbmid = value; }
    }
    public int Status
    {
        get { return status; }
        set { status = value; }
    }
    public int Login_idLogin1
    {
        get { return Login_idLogin; }
        set { Login_idLogin = value; }
    }
    public int User_type_idUser_type1
    {
        get { return User_type_idUser_type; }
        set { User_type_idUser_type = value; }
    }
}