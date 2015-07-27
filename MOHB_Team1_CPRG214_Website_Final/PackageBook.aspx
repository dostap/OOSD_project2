<%-- Author: Hazem Hegazy 
     Purpose: Customer Information page that selects 1 customer from the DB
     then displays their information - only UPDATE is allowed --%>

<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="PackageBook.aspx.cs" Inherits="PackageBook" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">
    <link href="Styles/PackageBook.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" Runat="Server">
        <br />
            <h1>Chosen Package</h1>
        <br />
        <asp:ObjectDataSource ID="odsPackage" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackage" TypeName="PackageDB">
            <SelectParameters>
                <asp:SessionParameter Name="packageId" SessionField="packageId" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
            <!-- form view to display the chosen package information -->
            <asp:FormView ID="fvBooking" runat="server" HorizontalAlign="Center" DataSourceID="odsPackage" Font-Bold="True" style="text-align: left" CellPadding="3">
                <EditItemTemplate>
                    PackageId:
                    <asp:TextBox ID="PackageIdTextBox" runat="server" Text='<%# Bind("PackageId") %>' />
                    <br />
                    PkgName:
                    <asp:TextBox ID="PkgNameTextBox" runat="server" Text='<%# Bind("PkgName") %>' />
                    <br />
                    PkgDesc:
                    <asp:TextBox ID="PkgDescTextBox" runat="server" Text='<%# Bind("PkgDesc") %>' />
                    <br />
                    PkgStartDate:
                    <asp:TextBox ID="PkgStartDateTextBox" runat="server" Text='<%# Bind("PkgStartDate") %>' />
                    <br />
                    PkgEndDate:
                    <asp:TextBox ID="PkgEndDateTextBox" runat="server" Text='<%# Bind("PkgEndDate") %>' />
                    <br />
                    PkgBasePrice:
                    <asp:TextBox ID="PkgBasePriceTextBox" runat="server" Text='<%# Bind("PkgBasePrice") %>' />
                    <br />
                    PkgAgencyCommission:
                    <asp:TextBox ID="PkgAgencyCommissionTextBox" runat="server" Text='<%# Bind("PkgAgencyCommission") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    PackageId:
                    <asp:TextBox ID="PackageIdTextBox" runat="server" Text='<%# Bind("PackageId") %>' />
                    <br />
                    PkgName:
                    <asp:TextBox ID="PkgNameTextBox" runat="server" Text='<%# Bind("PkgName") %>' />
                    <br />
                    PkgDesc:
                    <asp:TextBox ID="PkgDescTextBox" runat="server" Text='<%# Bind("PkgDesc") %>' />
                    <br />
                    PkgStartDate:
                    <asp:TextBox ID="PkgStartDateTextBox" runat="server" Text='<%# Bind("PkgStartDate") %>' />
                    <br />
                    PkgEndDate:
                    <asp:TextBox ID="PkgEndDateTextBox" runat="server" Text='<%# Bind("PkgEndDate") %>' />
                    <br />
                    PkgBasePrice:
                    <asp:TextBox ID="PkgBasePriceTextBox" runat="server" Text='<%# Bind("PkgBasePrice") %>' />
                    <br />
                    PkgAgencyCommission:
                    <asp:TextBox ID="PkgAgencyCommissionTextBox" runat="server" Text='<%# Bind("PkgAgencyCommission") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    Package ID:
                    <asp:Label ID="PackageIdLabel" runat="server" Text='<%# Bind("PackageId") %>' />
                    <br />
                    Package Name:
                    <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Bind("PkgName") %>' />
                    <br />
                    Package Description:
                    <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Bind("PkgDesc") %>' />
                    <br />
                    Start Date:
                    <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Bind("PkgStartDate", "{0:d}") %>' />
                    <br />
                    End Date:
                    <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Bind("PkgEndDate", "{0:d}") %>' />
                    <br />
                    Package Price:
                    <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Bind("PkgBasePrice", "{0:C}") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>
            
        <br /><br />

                <h4>Number of Travelers:</h4>
                <br />
                <!-- text box to accept the number of travellers from the customer for booking -->
                <asp:TextBox ID="txtTravelerCount" style="text-align:center" runat="server" MaxLength="2"></asp:TextBox>

        
            <!-- button to execute the booking method -->
            <asp:Button ID="btnBook" runat="server" Text="Book" OnClick="btnBook_Click" />
            <br />
            <asp:RequiredFieldValidator ID="valTravelerCountRequired" runat="server" ControlToValidate="txtTravelerCount" Display="Dynamic" ErrorMessage="Number of travellers is required." ForeColor="Red" style="text-align: left">Number of travellers is required.</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="valTravelerCountRange" runat="server" ControlToValidate="txtTravelerCount" Display="Dynamic" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="20" MinimumValue="1" Type="Integer">Number of travellers should be integer number between 1 and 20</asp:RangeValidator>
            <br />
            <!-- labelto display the saving status -->
            <asp:Label ID="lblSaveStatus" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnViewPackages" runat="server" Font-Bold="False" OnClick="btnPackages_Click" Text="View Packages" Width="153px" Visible="False" />
    
            <br />

       
    
</asp:Content>

