<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="login_body">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-7">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <span class="glyphicon glyphicon-lock"></span>Login
                        </div>
                        <div class="panel-body">
                            <form runat="server" class="form-horizontal" role="form">
                                <div class="form-group">
                                    <label for="inputEmail3" class="col-sm-3 control-label">
                                        Email</label>
                                    <div class="col-sm-9">
                                        <%--<input type="email" class="form-control" id="inputEmail3" placeholder="Email" required>--%>
                                         <asp:TextBox ID="login_email" input type="email"  runat="server" class="form-control" placeholder="E-mail" TextMode="Email" required></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="inputPassword3" class="col-sm-3 control-label">
                                        Password</label>
                                    <div class="col-sm-9">
                                        <%--<input type="password" class="form-control" id="inputPassword3" placeholder="Password" required>--%>
                                        <asp:TextBox ID="login_password" input type="password" runat="server" class="form-control" placeholder="Password" TextMode="Password" required></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-9 col-sm-offset-3">
                                        <asp:Label ID="warning" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <div class="checkbox">
                                            <label>
                                                <input type="checkbox" />
                                                Remember me
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group last">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <%--<button type="submit" class="btn btn-success btn-sm" style="padding-top: -5px">--%>
                                            <asp:Button ID="Sign_in_Button" class="btn btn-success btn-sm" runat="server" Text="Sign in" CommandName="s" OnClick="Sign_in_Button_Click"  />
                                           <%-- Sign in</button>--%>
                                            <%--<asp:Button ID="reset" input type="reset" CssClass="btn btn-default btn-sm " runat="server" Text="Reset"  "/>--%>
                                        <button type="reset" class="btn btn-default btn-sm">
                                            Reset</button>
                                    </div>
                                </div>
                            </form>
                        </div>
                        <div class="panel-footer">
                            Not Registred? <a href="http://www.jquery2dotnet.com">Register here</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

