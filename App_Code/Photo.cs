using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Photo
/// </summary>
public class Photo
{
	public Photo()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void WriteToFile(string strPath,  byte[] Buffer)
    {
        FileStream newFile = new FileStream(strPath, FileMode.Create);
        newFile.Write(Buffer, 0, Buffer.Length);

        newFile.Close();
    }

    
}