﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Category
/// </summary>
public class Category
{
    int idCategory;
    String categoryName;

    

	public Category()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public String CategoryName
    {
        get { return categoryName; }
        set { categoryName = value; }
    }


    public int IdCategory
    {
        get { return idCategory; }
        set { idCategory = value; }
    }

}