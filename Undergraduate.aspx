<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Undergraduate.aspx.cs" Inherits="Default2" %>

<%@ Import Namespace="MySql.Data.MySqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <%  String s = Request.QueryString["catid"];

        if (s != null)
        {

            Category c = new Category();
            c.IdCategory = Int16.Parse(s);

            ProgrammeController pc = new ProgrammeController();

            MySqlDataReader dr = pc.getCategoryData(c);
            


            while (dr.Read())
            { 
    %>

                <h5 style="color: blue"><%=dr["Category_Name"] %></h5>


   
    <%           MySqlDataReader dr2 = pc.getSchoolData(c);      %>

                   
    
                 <h6 style="color: blueviolet"> <%=dr2["School_name"] %></h6>

                <%-- <h6 style="color: blueviolet"> <%=dr["Programme_Name"] %></h6>--%>



    <%
             
             }



             dr.Close();


        }
        else
        {

            Response.Redirect("Home.aspx");
        }
        
        
        
         
         
         
         
    %>
</asp:Content>

