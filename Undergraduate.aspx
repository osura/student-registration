<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Undergraduate.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Content/footable.min.css" rel="stylesheet" />
    <script src="Scripts/footable.min.js">

     <script type="text/javascript">
         $(function () {
             $('[id*=GridView1]').footable();
         });
    </script>
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <asp:GridView ID="GridView1" CssClass="footable" runat="server" AutoGenerateColumns="false"
        Style="max-width: 500px">
        <Columns>
            <asp:BoundField DataField="Programme_Code" HeaderText="Code" />
            <asp:BoundField DataField="Programme_Name" HeaderText="Name" />
            <asp:BoundField DataField="Category_idCategory" HeaderText="Categorey" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="Fee" HeaderText="Fee" />
            <asp:BoundField DataField="A/L_results_criteria" HeaderText="A/L results" />
            <asp:BoundField DataField="School_idSchool" HeaderText="School" />
            <asp:BoundField DataField="Accredited_By_idAccredited_By" HeaderText="Accredited By" />
        </Columns>
    </asp:GridView>



</asp:Content>

