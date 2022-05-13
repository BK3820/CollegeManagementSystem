<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/SiteLogin.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CollegeManagementSystem.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <div >
        <h3> Login</h3<br />
        <pre>
         
        <asp:Label ID="lbluserName" runat="server" Text="User Name :"></asp:Label>
        <asp:TextBox ID="txtuserName" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator_username" runat="server" ErrorMessage="Enter Username" ControlToValidate="txtuserName" ForeColor="Red"></asp:RequiredFieldValidator>
        
        <asp:Label ID="lblPassword" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator_password" runat="server" ErrorMessage="Enter Password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  OnClick="btnSubmit_Click" />
        
        
        
        
        
        
        
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"  ></asp:Label>
          </pre> 
    </div>
</asp:Content>
