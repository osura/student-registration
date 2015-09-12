<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/dobpicker/dobPicker.min.js"></script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server" method="post" style="margin-bottom: 1.5%" enctype="multipart/form-data">
        <div class="form_title">
            <h2 style="text-align: center">Registration</h2>
        </div>
        <div class="reg_form">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="col-md-4 col-sm-12 col-xs-12 col-md-offset-4">
                            <div class="form-group">
                                <label for="Name">Full Name</label>
                                <asp:TextBox ID="fname" runat="server" class="form-control" placeholder="First Name"></asp:TextBox>
                                <asp:TextBox ID="mname" runat="server" class="form-control" placeholder="Middle Name"></asp:TextBox>
                                <asp:TextBox ID="lname" runat="server" class="form-control" placeholder="Last Name"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="DOB">Date of Birth</label>
                                <select id="dobday"></select>
                                <select id="dobmonth"></select>
                                <select id="dobyear"></select>
                            </div>
                            <div class="form-group">
                                <label for="Gender">Gender</label>
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Value="1">Male</asp:ListItem>
                                    <asp:ListItem Value="2">Female</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="username">Username</label>
                                <asp:TextBox ID="username" runat="server" class="form-control" placeholder="Username"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="Email">E-mail</label>
                                <asp:TextBox ID="email" runat="server" class="form-control" placeholder="E-mail" TextMode="Email"></asp:TextBox>
                                <asp:TextBox ID="email2" runat="server" class="form-control" placeholder="Re-enter E-mail" TextMode="Email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="Password">Password</label>
                                <asp:TextBox ID="password" runat="server" class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                                <asp:TextBox ID="password2" runat="server" class="form-control" placeholder="Re-enter Password" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="Address">Address</label>
                                <asp:TextBox ID="aline1" runat="server" class="form-control" placeholder="Address line"></asp:TextBox>
                                <asp:TextBox ID="aline2" runat="server" class="form-control" placeholder="Address line"></asp:TextBox>
                                <asp:TextBox ID="aline3" runat="server" class="form-control" placeholder="Address line"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="Contact">Contact No</label>
                                <asp:TextBox ID="contact" runat="server" class="form-control" placeholder="Contcat No" TextMode="Phone"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="InputFile">Photo</label>
                                <asp:FileUpload ID="FileUpload" runat="server" accept="image/*" />
                                <p class="help-block">(2 x 2 inches)</p>
                            </div>

                            <asp:Button ID="Submit_Button" class="btn btn-default" runat="server" Text="Submit" CommandName="s" OnClick="Submit_Button_Click" />

                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>


    <script src="Scripts/dobpicker/dobPicker_ready.js"></script>
</asp:Content>

