<%-- Author: Bade-Adebowale Kehinde
     Purpose: Design of contacts page
     Date: July 20, 2015--%>

<%@ Page MasterPageFile="~/Main.master" Language="C#" AutoEventWireup="true" CodeFile="ContactsAgent.aspx.cs" Inherits="ContactsAgent" %>

<asp:content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">  
    <link href="Styles/ContactsAgent.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style6 {
            width: 0%;
            height: 28px;
        }
        .auto-style9 {
            width: 500px;
        }
        .auto-style10 {
            width: 189%;
        }
        .auto-style11 {
            width: 753px;
        }
    </style>
</asp:content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="Server">
    <div id="contactsAgents" align="center">
        <table class="auto-style6">
            <tr>
                <td class="auto-style9">
                    <table class="auto-style10">
                        <tr>
                            <td class="auto-style11">
        <asp:FormView ID="FormView3" runat="server" AllowPaging="True" BackColor="DarkBlue" FooterStyle-Height="12" HeaderStyle-BackColor="DarkBlue" HeaderStyle-Height="8" Font-Bold="True" Font-Size="Large"  CellPadding="4" DataSourceID="ObjectDataSource1" EmptyDataText="EMPTY" ForeColor="#333333" Width="744px" Height="603px" OnPageIndexChanging="FormView1_PageIndexChanging" BorderColor="#0099CC" BorderStyle="Solid" BorderWidth="15px" CaptionAlign="Left" style="text-align: left"> 
            <FooterStyle HorizontalAlign="Center" Font-Bold="True" ForeColor="White" Width="30px" BackColor="#0099CC" BorderColor="#0099CC" BorderStyle="Solid" BorderWidth="10px" />
            <FooterTemplate>
                Click To View Next Agent
            </FooterTemplate> 
            <HeaderStyle HorizontalAlign="Center" BackColor="#0099CC" BorderColor="#0099CC" BorderStyle="Solid" BorderWidth="15px" Font-Bold="True" Font-Size="Large" ForeColor="White" />
            <HeaderTemplate>
               CALGARY LOCATION
            </HeaderTemplate>
            <ItemTemplate>
            
                <br />
                Agent&#39;s Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Label ID="AgentIdLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgentId") %>' />
                <br />
                <br />
                Agent&#39;s FirstName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Label ID="AgtFirstNameLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtFirstName") %>' />
                <br />
                <br />
                Agent&#39;s Middle Initial:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="AgtMiddleInitialLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtMiddleInitial") %>' />
                <br />
                <br />
                Agent&#39;s Bus. Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="AgtBusPhoneLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtBusPhone") %>' />
                <br />
                <br />
                Agent&#39;s Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="AgtEmailLabel" runat="server" ForeColor="DeepSkyBlue" Font-Size="Large" Text='<%# Bind("AgtEmail") %>' />
                <br />
                <br />
                Agent&#39;s Position:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="AgtPositionLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtPosition") %>' />
                <br />
                <br />
                Agency Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Label ID="AgencyIdLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgencyId") %>' />
                <br />
                
            </ItemTemplate>
            <PagerSettings NextPageText="Next" PreviousPageText="Previous" />
            <PagerStyle BackColor="#284775" Font-Size="Larger" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
                            </td>
                            <td>
        <asp:FormView ID="FormView4" runat="server" AllowPaging="True" HeaderStyle-BackColor="DarkBlue" HeaderStyle-Height="8" FooterStyle-Height="12" Font-Bold="True" Font-Size="Large"  CellPadding="4" DataSourceID="ObjectDataSource2" EmptyDataText="EMPTY" ForeColor="#333333" Width="744px" Height="603px" OnPageIndexChanging="FormView1_PageIndexChanging" BorderColor="#0099CC" BorderStyle="Solid" BorderWidth="15px" style="text-align: left">
            <FooterStyle HorizontalAlign="Center" Font-Bold="True" ForeColor="White" Width="30px" BackColor="#0099CC" BorderColor="#0099CC" BorderStyle="Solid" BorderWidth="10px" />
            <FooterTemplate>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click To View Next Agent
            </FooterTemplate>         
            <HeaderStyle HorizontalAlign="Center" BackColor="#0099CC" BorderColor="#0099CC" BorderStyle="Solid" BorderWidth="15px" Font-Bold="True" Font-Size="Large" ForeColor="White" />
            <HeaderTemplate>
                &nbsp;&nbsp;OKOTOKS LOCATION
            </HeaderTemplate>
            
            <ItemTemplate>
                
                Agent&#39;s Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="AgentIdLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgentId") %>' />
                <br />
                <br />
                Agent&#39;s FirstName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="AgtFirstNameLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtFirstName") %>' />
                <br />
                <br />
                Agent&#39;s Middle Initial:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                 <asp:Label ID="AgtMiddleInitialLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtMiddleInitial") %>' />
                <br />
                <br />
                Agent&#39;s Bus. Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="AgtBusPhoneLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtBusPhone") %>' />
                <br />
                <br />
                Agent&#39;s Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="AgtEmailLabel" runat="server" Font-Size="Large" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtEmail") %>' />
                <br />
                <br />
                Agent&#39;s Position:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="AgtPositionLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgtPosition") %>' />
                <br />
                <br />
                AgencyId:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="AgencyIdLabel" runat="server" ForeColor="DeepSkyBlue" Text='<%# Bind("AgencyId") %>' />
                <br />
                
            </ItemTemplate>
                
            <PagerSettings NextPageText="Next" PreviousPageText="Previous" FirstPageText="First Agent by Agent's Id" LastPageText="Last Agent by Agent's Id" />
            <PagerStyle BackColor="#284775" Font-Size="Larger" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <br />
        <br />

 

        <!-- Object data sources-->
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAgentsinAgency_2" TypeName="AgentsDB"></asp:ObjectDataSource>

        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAgentsinAgency_1" TypeName="AgentsDB"></asp:ObjectDataSource>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAgentsinAgency_1" TypeName="AgentsDB"></asp:ObjectDataSource>
        <br />
        <br />
    </div>
</asp:Content>