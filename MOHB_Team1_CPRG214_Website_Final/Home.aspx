<%-- Author: (Terry) Soktheary Mao, Darya Ostapenko
     Purpose: Design of home page
     Date: July 20, 2015--%>

<%@ Page MasterPageFile="~/Main.master" Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">  
    <link href="Styles/Home.css" rel="stylesheet" />
</asp:content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="Server">
    <div id="homePage">
        <h1>Travel Experts exclusive destinations!</h1>
        <div id="topRow">
        <div id="content1">
            <a href="VacationPackages.aspx">
                <h3>Caribbean</h3>
            </a>
            <div>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/caribbean1.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/caribbean2.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/caribbean3.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/caribbean5.jpg" />
                </a>
            </div>
            
        </div>
        
        <div id="content2">
            <a href="VacationPackages.aspx">
                <h3>Polynesia</h3>
            </a>
            <div>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/polynesia1.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/polynesia2.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/polynesia3.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/polynesia4.jpg" />
                </a>
            </div>
        </div>
        </div><!--end of topRow div-->

        <div id="bottomRow">
        <div id="content3">
            <a href="VacationPackages.aspx">
                <h3>Asia</h3>
            </a>
            <div>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/asia1.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/japan1.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/asia3.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/asia4.jpg" />
                </a>   
            </div>
        </div>

        <div id="content4">
            <a href="VacationPackages.aspx">
                <h3>Europe</h3>
            </a>
            <div>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/europe1.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/europe2.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/europe3.jpg" />
                </a>
                <a href="VacationPackages.aspx">
                    <img class="homeImg" src="Images/destinations/europe4.jpg" />
                </a>
            </div>
        </div>
            </div> 

    </div><!--homepage div-->
</asp:Content>
