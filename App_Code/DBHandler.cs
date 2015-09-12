using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Data;


class DBHandler
{
    MySqlConnection cn;

    public DBHandler()
    {
        cn = new MySqlConnection();
        cn.ConnectionString = "server=localhost;user id=root;database=student_registration";

    }


    public string InsertData(MySqlCommand cm)
    {
        string m;

        try
        {
            cm.Connection = cn;

            cn.Open();
            if (cm.ExecuteNonQuery() == 1)
            { m = "Data Saved"; }

            else { m = "Data not Saved"; }

            cn.Close();

        }
        catch (Exception e)
        {
            m = e.Message;
        }

        return m;

    }

    public DataTable GetData(MySqlCommand cm)
    {
        cm.Connection = cn;


        MySqlDataAdapter adp = new MySqlDataAdapter(cm);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        return dt;

    }
}