using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Programme
/// </summary>
public class Programme
{

    string programme_Name;
    int category_idCategory;
    string description;
    double fee;
    string al_results_criteria;
    int school_idSchool;
    int accredited_By_idAccredited_By;

    public Programme()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Programme_Name
    {
        get { return programme_Name; }
        set { programme_Name = value; }
    }

    public int Category_idCategory
    {
        get { return category_idCategory; }
        set { category_idCategory = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public double Fee
    {
        get { return fee; }
        set { fee = value; }
    }

    public string Al_results_criteria
    {
        get { return al_results_criteria; }
        set { al_results_criteria = value; }
    }

    public int School_idSchool
    {
        get { return school_idSchool; }
        set { school_idSchool = value; }
    }

    public int Accredited_By_idAccredited_By
    {
        get { return accredited_By_idAccredited_By; }
        set { accredited_By_idAccredited_By = value; }
    }
}