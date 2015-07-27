<%-- Author: Bade-Adebowale Kehinde
     Purpose: WebForm for About Us page
     Date: July 21, 2015 --%>

<%@ Page MasterPageFile="Main.master" Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">  
    <link href="Styles/About.css" rel="stylesheet" />
</asp:content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="Server">
    <br />
    <div id="tblAbout">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <p class="ArialFont8ptBlack">
                    Dear Travel Expert&#39;s Customer,</p>
                <div align="left">
                    <pre class="ArialFont8ptBlack" style="margin-bottom:5px;">
                        Travel Expert has become the leading, integrated leisure tour operator in Canada since it began operation in 2015.
                         
                        PS: Do not mistake our fast rise to the top as luck.

                        We are a professionally managed and operated business, and one of Canada&#39;s fastest growing and most successful 
                        vacation and travel service provider. Travel Expert, Canada&#39;s premier leisure vacation service provider is 
                        consistently voted the #1 leisure travel expert by MOHB Travel Agents, we providing Champagne Service at a low cost 
                        and also provide travel packages for low income erners. Travel Expert&#39;s prides itself in having innovative, creative, 
                        and forward thinking management, which allows us to be pioneers in creating new products, packages new concepts, 
                        and new ideas.
                    </pre>
                </div>
                <div align="left">
                    <pre>
                                           Head Office Location here in Calgary.            Branch Location in Okotoks.
                    </pre>
                </div>
            </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2508.3677496242512!2d-114.08855869999996!3d51.04629709999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x53716fe76e972489%3A0x149461cedf5b7c5b!2s1155+8+Ave+SW%2C+Calgary%2C+AB+T2P!5e0!3m2!1sen!2sca!4v1437488136005" height="300" frameborder="0" style="border-style: none; border-color: inherit; border-width: 0; width: 400px;" id="I1" name="I1"></iframe>
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2525.448870799907!2d-113.98166650553587!3d50.73016305952452!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x537198341269b66d%3A0xe1b9def6889bf027!2sAxis+Realty+Ltd!5e0!3m2!1sen!2sca!4v1437869524002" height="300" frameborder="0" style="border-style: none; border-color: inherit; border-width: 0; width: 400px;" id="Iframe1" name="I1"></iframe>
            </td>
        </tr>
    </table>
    </div>
    <br />
</asp:Content>