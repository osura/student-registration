<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Graduate.aspx.cs" Inherits="Default2" %>

<%@ Import Namespace="MySql.Data.MySqlClient" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">

    <%  String s = Request.QueryString["catid"];

        if (s != null)
        {

            Category c = new Category();
            c.IdCategory = Int16.Parse(s);

            ProgrammeController pc = new ProgrammeController();

            DataTable dt = pc.getProgrammeDataTable(c);



            DataView view = new DataView(dt);
            String[] columnnames = new String[] { "idCategory", "Category_Name" };
            DataTable categorydistinctValues = view.ToTable(true, columnnames);
            string catogoryName = dt.Rows[0]["Category_Name"].ToString();
            
            
            
    %>

               <div class="col-xs-12 col-md-12 text-center"> <h4 style="color: blue"><%=catogoryName %></h4>

    <% 
            String[] columnnames2 = new String[] { "idSchool", "School_name" };
            DataTable schoolNamedistinctValues = view.ToTable(true, columnnames2);

                String sname;
                
                String aby;
                 for( int a = 0 ; a < schoolNamedistinctValues.Rows.Count ; a ++)
                    {
                       
                     sname=schoolNamedistinctValues.Rows[a]["School_name"].ToString();
                     
                     %>
                      
                      <div class="col-xs-12 col-md-12 text-center"> <h4 style="color:chocolate"><u> <%=sname %> </u> </h4></div>
                     <%
                        
                        String[] columnnames3 = new String[] { "idAccredited_By", "Accredited_Bycol", "School_name" };
                        DataTable accreditedByNamedistinctValues = view.ToTable(true,columnnames3);
                        DataRow[] accreditedBySet = accreditedByNamedistinctValues.Select("School_name ='" + sname + "'");
                        
                        
                        
                            foreach (DataRow row in accreditedBySet)
                            {
                                aby = row["Accredited_Bycol"].ToString();
                        
                        %>
                           <div class="col-xs-12 col-md-12 text-center"> <b> <%=aby%> </b><br/></div>
                        <%
                                DataRow[] programenameset = dt.Select("School_name ='" + sname + "' AND Accredited_Bycol='" + aby + "'");

                                foreach (DataRow row1 in programenameset)
                                {%>
                                    <div class="col-xs-12 col-md-12 text-center"> <%=row1["Programme_Name"]%><br/></div>
                             
                                <%
                                }
                        }


                       
                     }

    %>          
    
                 

                



    <%
             
            



            


        }
        else
        {

            Response.Redirect("Home.aspx");
        }
        
        
        
         
         
         
         
    %>
   </div>
</asp:Content>

