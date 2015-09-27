using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for DBConnection
/// </summary>
public class DBConnection
{
    private static MySqlConnection cn;



	public DBConnection()
	{
		
	}

    public static MySqlConnection getConnetion() {

        if (cn == null) {

            cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost;user id=root;database=student_registration";
            cn.Open();

        }

        return cn;

    }


}