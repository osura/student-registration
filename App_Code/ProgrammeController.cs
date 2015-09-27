using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for ProgrammeController
/// </summary>
public class ProgrammeController
{
    DBHandler db;
    MySqlCommand cm;        

	public ProgrammeController()
	{
        db = new DBHandler();
        cm = new MySqlCommand();
	}

    public string addProgramme(Programme m) {

        cm.CommandText = "Insert into Programme(Programme_Name,Category_idCategory,Description,Fee,A/L_results_criteria,School_idSchool,Accredited_By_idAccredited_By) values(@a,@b,@c,@d,@e,@f,@g)";

        cm.Parameters.AddWithValue("a", m.Programme_Name);
        cm.Parameters.AddWithValue("b", m.Category_idCategory);
        cm.Parameters.AddWithValue("c", m.Description);
        cm.Parameters.AddWithValue("d", m.Fee);
        cm.Parameters.AddWithValue("e", m.Al_results_criteria);
        cm.Parameters.AddWithValue("f", m.School_idSchool);
        cm.Parameters.AddWithValue("g", m.Accredited_By_idAccredited_By);

        return db.InsertData(cm);
    }

    public MySqlDataReader getProgrammeData(Category c) {

        cm.CommandText = "SELECT * FROM category INNER JOIN programme  ON category.idCategory=programme.Category_idCategory INNER JOIN school ON school.idSchool=programme.School_idSchool INNER JOIN accredited_by ON accredited_by.idAccredited_By=programme.Accredited_By_idAccredited_By WHERE category.idCategory='"+c.IdCategory+"'; ";

        MySqlDataReader dt = db.GetDataAsDataReader(cm);
        return dt;

    }

    public MySqlDataReader getCategoryData(Category c) {

        cm.CommandText = "SELECT DISTINCT Category_Name FROM category INNER JOIN programme  ON category.idCategory=programme.Category_idCategory INNER JOIN school ON school.idSchool=programme.School_idSchool INNER JOIN accredited_by ON accredited_by.idAccredited_By=programme.Accredited_By_idAccredited_By WHERE category.idCategory='" + c.IdCategory + "'; ";

        MySqlDataReader dt = db.GetDataAsDataReader(cm);
        return dt;
    }


    public MySqlDataReader getSchoolData(Category c) {

        cm.CommandText = "SELECT DISTINCT School_name FROM category INNER JOIN programme  ON category.idCategory=programme.Category_idCategory INNER JOIN school ON school.idSchool=programme.School_idSchool INNER JOIN accredited_by ON accredited_by.idAccredited_By=programme.Accredited_By_idAccredited_By WHERE category.idCategory='" + c.IdCategory + "'; ";

        MySqlDataReader dt = db.GetDataAsDataReader(cm);
        return dt;
    }

    public DataTable getProgrammeDataTable(Category c) {

        cm.CommandText = "SELECT * FROM category INNER JOIN programme  ON category.idCategory=programme.Category_idCategory INNER JOIN school ON school.idSchool=programme.School_idSchool INNER JOIN accredited_by ON accredited_by.idAccredited_By=programme.Accredited_By_idAccredited_By WHERE category.idCategory='" + c.IdCategory + "'; ";

        DataTable dt = db.GetData(cm);

        return dt;
    
    }

   

}