using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Module
/// </summary>
public class Module
{


    int semester;
    String credits_Allocated;
    String description;
    int programme_Programme_Code;



    public Module()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int Semester
    {
        get { return semester; }
        set { semester = value; }
    }

    public String Credits_Allocated
    {
        get { return credits_Allocated; }
        set { credits_Allocated = value; }
    }

    public String Description
    {
        get { return description; }
        set { description = value; }
    }

    public int Programme_Programme_Code
    {
        get { return programme_Programme_Code; }
        set { programme_Programme_Code = value; }
    }
}