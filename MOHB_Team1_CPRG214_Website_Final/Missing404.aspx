<%-- Author: (Terry) Soktheary Mao
     Purpose: Redirects user to a missing page if a customer/anonymous user tries to access without a session
     Date: July 24, 2015--%>


<%@ Page MasterPageFile="~/Main.master" Language="C#" AutoEventWireup="true" CodeFile="Missing404.aspx.cs" Inherits="Missing404" %>

<asp:content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">  
</asp:content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="Server">
    <div id="Error404">
        <h1>HTTP ERROR 404. This page was not found.</h1>
        <br /> 
        <h1>If you believe you accessed this page correctly,
        please try <a href="Login.aspx"><u>logging</u></a> in first.</h1>
    </div>
</asp:Content>
