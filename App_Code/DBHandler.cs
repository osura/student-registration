using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Data;


class DBHandler
{
    private MySqlConnection cn;

    public DBHandler()
    {

        cn = DBConnection.getConnetion();
    }


    public string InsertData(MySqlCommand cm)
    {
        string m;

        try
        {
            cm.Connection = cn;

            
            if (cm.ExecuteNonQuery() == 1)
            { m = "Data Saved"; }

            else { m = "Data not Saved"; }

            

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

    public MySqlDataReader GetDataAsDataReader(MySqlCommand cm) {

        cm.Connection = cn;
        
        MySqlDataReader dr = cm.ExecuteReader();

      
        return dr;

    }
}