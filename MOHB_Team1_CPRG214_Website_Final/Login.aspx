<%-- Author: (Terry) Soktheary Mao,  Darya Ostapenko
     Purpose: Design of login page
     Date: July 20, 2015--%>

<%@ Page MasterPageFile="~/Main.master" Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">  
    <link href="Styles/Login.css" rel="stylesheet" />
</asp:content>

        
<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="Server">
    <div id="dvLogin">
        <h1>Please enter your Travel Experts Username and Password </h1>
            <table id="tblLogin" align="center">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtCustUserName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustUserName" Display="Dynamic" ErrorMessage="Username is required to login." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtCustPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCustPassword" Display="Dynamic" ErrorMessage="Password is required to login." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnCancel" runat="server" PostBackUrl="~/Home.aspx" Text="Cancel" CausesValidation="False" />
                    </td>
                    <td>
                        <asp:Label ID="lblRegister" runat="server" ForeColor="#009933">Need an Account? Register <a href="Registration.aspx"><u>here.</u></a></asp:Label>
                        <br />
                        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
          </table>

            </div>
</asp:Content>
