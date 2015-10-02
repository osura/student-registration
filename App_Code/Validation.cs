using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for Validation
/// </summary>
public class Validation
{
	public Validation()
	{
		//
		// TODO: Add constructor logic here
		//
	}

   public bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

   public bool isValidPassword(string password) {

       string sPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*d).{8,15}$";

       if (System.Text.RegularExpressions.Regex.IsMatch(password, sPattern)) {

           return true;
       }
       return false;
   }
}