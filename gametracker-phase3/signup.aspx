<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="gametracker_phase3.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Author: Jing Zhou & Hinaben Patel-->
    <!--Date : 07/10/2016-->
    <!--Project Name: Game Tracker-->
    <!--Description: Sign up page-->
    <div class="conatainer">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">

                <!-- Message box for sign up not sucessful -->
                  <div class="alert alert-danger" id="AlertFlash" runat="server" visible="false">
                    <asp:Label runat="server" ID="StatusLabel" />
                </div>

                <h1>Sign up</h1>

                <div class="form-group">
                    <label for="UserNameTextBox">User Name</label>
                    <asp:TextBox CssClass="form-control" ID="UserNameTextBox" runat="server" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="ContactNumberTextBox">Contact Number</label>
                    <asp:TextBox CssClass="form-control" ID="ContactNumberTextBox" runat="server" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="EmailTextBox">Email</label>
                    <asp:TextBox TextMode="Email" CssClass="form-control" ID="EmailTextBox" runat="server" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="PasswordTextBox">Password:</label>
                    <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PasswordTextBox" required="true" TabIndex="0"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="ConfirmPasswordTextBox">Confirm Password:</label>
                    <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="ConfirmPasswordTextBox"  required="true" TabIndex="0"></asp:TextBox>
                    <asp:CompareValidator ErrorMessage="Passwords Does Not Match" Type="String" Operator="Equal" ControlToValidate="ConfirmPasswordTextBox" runat="server"
                        ControlToCompare="PasswordTextBox" CssClass="label label-danger" />
                </div>
                <asp:Button Text="Cancel" ID="CancelButton" runat="server" CssClass="btn btn-warning" OnClick="CancelButton_Click" UseSubmitBehavior="false" CausesValidation="false" TabIndex="0" />
                <asp:Button ID="SignUpButton" CssClass="btn btn-primary btn-md" runat="server" Text="Sign up" OnClick="SignUpButton_Click" />

            </div>
        </div>
    </div>

</asp:Content>
