<%@ Page Title="Signin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="gametracker_phase3.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <!--Author: Jing Zhou & Hinaben Patel-->
<!--Date : 07/10/2016-->
<!--Project Name: Game Tracker-->
<!--Description: Sign in page-->
    <div class="conatainer">
        <div class="row">
            <div class="col-md-offset-4 col-md-6">
                <!-- Sign in not successful message -->
                <div class="alert alert-danger" id="AlertFlash" runat="server" visible="false">
                    <asp:Label runat="server" ID="SigninFailedLabel" />
                </div>

                <h1>Sign in</h1>

                <div class="panel-body">
                        <div class="form-group">
                            <label class="control-label" for="UserNameTextBox">Username:</label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="UserNameTextBox" placeholder="Username" required="true" TabIndex="0"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label class="control-label" for="PasswordTextBox">Password:</label>
                            <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PasswordTextBox" placeholder="Password" required="true" TabIndex="0"></asp:TextBox>
                        </div>

                        <div class="text-right">
                            <asp:Button Text="Sign in" ID="SigninButton" runat="server" CssClass="btn btn-primary" OnClick="SigninButton_Click" TabIndex="0" />
                        </div>

                    </div>
            </div>
        </div>
    </div>

</asp:Content>

