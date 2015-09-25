using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProgrammeController pc=new ProgrammeController();

        GridView1.DataSource =pc.getProgrammeData() ;
        GridView1.DataBind();


        //Attribute to show the Plus Minus Button.
        GridView1.HeaderRow.Cells[0].Attributes["data-class"] = "expand";

        //Attribute to hide column in Phone.
        GridView1.HeaderRow.Cells[2].Attributes["data-hide"] = "phone";
        GridView1.HeaderRow.Cells[3].Attributes["data-hide"] = "phone";

        //Adds THEAD and TBODY to GridView.
        GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;

    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        //base.VerifyRenderingInServerForm(control);
    }
}