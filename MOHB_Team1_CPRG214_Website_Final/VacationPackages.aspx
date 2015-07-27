<%-- Author: Darya Ostapenko
     Purpose: WebForm for VacationPackages
     Date: July 21, 2015 --%>

<%@ Page MasterPageFile="~/Main.master" Language="C#" AutoEventWireup="true" CodeFile="VacationPackages.aspx.cs" Inherits="VacationPackages" %>
<asp:Content ID="headContent" runat="server" contentplaceholderid="headPlaceHolder">
    <link href="Styles/VacationPackages.css" rel="stylesheet" />
    <script src="Js/jquery.min.js"></script>
    <script type="text/javascript">
    $(document).ready(function () {
        $("#imgPkg1").mouseover(function () {

            $(this).next("a").hide();
        });
        $("#imgPkg1").mouseout(function () {
            $(this).next("a").show();
        });

    });
</script>
    </asp:Content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <div id="container">
        <h1>Pick Your Destination</h1>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="False">&quot;You have not logged in. Please <a href="Login.aspx">Login</a> to book a Package. Or Register <a href="Registration.aspx">here.</a>&quot;;</asp:Label>
        <div id="row1">
            <div class="imgPackage">
                <h3>Caribbean New Year</h3>
                    <asp:ImageButton id="imgPkg1" runat="server" ImageUrl="~/Images/destinations/caribbean8to5.jpg" OnClick="imgPkg1_Click"/>
                <br />
                <asp:FormView ID="FormViewPkg1" CssClass="formViewPkg" runat="server" DataSourceID="ObjectDataSource1" 
                    Visible="False" OnDataBound="FormViewPkg1_DataBound">
  
                    <ItemTemplate>
                        Package Name:
                        <asp:Label ID="PkgNameLabel"  runat="server" Text='<%# Bind("PkgName") %>' />
                        <br />
                        Package Description:
                        <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Bind("PkgDesc") %>' />
                        <br />
                        Package Start Date:
                        <asp:Label ID="PkgStartDateLabel" runat="server"  Text='<%# Bind("PkgStartDate","{0:D}") %>' />
                        <br />
                        Package End Date:
                        <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Bind("PkgEndDate","{0:D}") %>' />
                        <br />
                        Package Base Price:
                        <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Bind("PkgBasePrice","{0:c}") %>' />
                        <br />

                    </ItemTemplate>
                </asp:FormView>

                <asp:Button ID="btnBookPkg1" CssClass="buttonBook" runat="server" OnClick="btnBookPkg1_Click" Text="Book Now!" Visible="False" />
                <br />
                <asp:Label ID="lblPkg1NotAvailable" runat="server" Font-Bold="True" ForeColor="Red" 
                    Text="This package is no longer available!" Visible="False"></asp:Label>
               </div>

            <div class="imgPackage">
                <h3>Polynesian Paradise</h3>
                <asp:ImageButton id="imgPkg2" runat="server" ImageUrl="~/Images/destinations/polynesia8to5.jpg" OnClick="imgPkg2_Click" />
                 <br />
                <asp:FormView ID="FormViewPkg2" CssClass="formViewPkg" runat="server" DataSourceID="ObjectDataSource1" Visible="False" OnDataBound="FormViewPkg2_DataBound">
       
                    <ItemTemplate>
                       
                        Package Name:
                        <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Bind("PkgName") %>' />
                        <br />
                        Package Description:
                        <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Bind("PkgDesc") %>' />
                        <br />
                        Package Start Date:
                        <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Bind("PkgStartDate","{0:D}") %>' />
                        <br />
                        Package End Date:
                        <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Bind("PkgEndDate","{0:D}") %>' />
                        <br />
                        Package Base Price:
                        <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Bind("PkgBasePrice","{0:c}") %>' />
                        <br />
                    </ItemTemplate>
                </asp:FormView>
                 <asp:Button ID="btnBookPkg2" CssClass="buttonBook" runat="server" OnClick="btnBookPkg2_Click" Text="Book Now!" Visible="False" />
                <br />
                <asp:Label ID="lblPkg2NotAvailable" runat="server" Font-Bold="True" ForeColor="Red" Text="This package is no longer available!" Visible="False"></asp:Label>
            </div>
        </div><!--end of row1-->
        <br />
        <div id="row2">
            <div class="imgPackage">
                <h3>Asian Expedition</h3>
                    <asp:ImageButton id="imgPkg3" runat="server" ImageUrl="~/Images/destinations/japan8to5.jpg" OnClick="imgPkg3_Click" />
                <br />
                <asp:FormView ID="FormViewPkg3" CssClass="formViewPkg" runat="server" DataSourceID="ObjectDataSource1" Visible="False" OnDataBound="FormViewPkg3_DataBound">
          
                    <ItemTemplate>
                       
                        Package Name:
                        <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Bind("PkgName") %>' />
                        <br />
                        Package Description:
                        <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Bind("PkgDesc") %>' />
                        <br />
                        Package Start Date:
                        <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Bind("PkgStartDate","{0:D}") %>' />
                        <br />
                        Package End Date:
                        <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Bind("PkgEndDate","{0:D}") %>' />
                        <br />
                        Package Base Price:
                        <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Bind("PkgBasePrice","{0:c}") %>' />
                        <br />

                    </ItemTemplate>
                </asp:FormView>
                 <asp:Button ID="btnBookPkg3" CssClass="buttonBook" runat="server" OnClick="btnBookPkg3_Click" Text="Book Now!" Visible="False" />
                <br />
                <asp:Label ID="lblPkg3NotAvailable" runat="server" Font-Bold="True" ForeColor="Red" Text="This package is no longer available!" Visible="False"></asp:Label>
            </div>

            <div class="imgPackage">
                <h3>European Vacation</h3>
                    <asp:ImageButton id="imgPkg4" runat="server" ImageUrl="~/Images/destinations/europe8to5.jpg" OnClick="imgPkg4_Click" />

                <br />
                <asp:FormView ID="FormViewPkg4" CssClass="formViewPkg" runat="server" DataSourceID="ObjectDataSource1" Visible="False" 
                    OnDataBound="FormViewPkg4_DataBound">
                   
                    <ItemTemplate>
                        
                        Package Name:
                        <asp:Label ID="PkgNameLabel" runat="server" Text='<%# Bind("PkgName") %>' />
                        <br />
                        Package Description:
                        <asp:Label ID="PkgDescLabel" runat="server" Text='<%# Bind("PkgDesc") %>' />
                        <br />
                        Package Start Date:
                        <asp:Label ID="PkgStartDateLabel" runat="server" Text='<%# Bind("PkgStartDate","{0:D}") %>' />
                        <br />
                        Package End Date:
                        <asp:Label ID="PkgEndDateLabel" runat="server" Text='<%# Bind("PkgEndDate","{0:D}") %>' />
                        <br />
                        Package Base Price:
                        <asp:Label ID="PkgBasePriceLabel" runat="server" Text='<%# Bind("PkgBasePrice","{0:c}") %>' />
                        <br />
                    </ItemTemplate>
                </asp:FormView>
                 <asp:Button ID="btnBookPkg4" CssClass="buttonBook" runat="server" OnClick="btnBookPkg4_Click" Text="Book Now!" Visible="False" />
                <br />
                <asp:Label ID="lblPkg4NotAvailable" runat="server" Font-Bold="True" ForeColor="Red" 
                    Text="This package is no longer available!" Visible="False"></asp:Label>
            </div>
            </div><!--end of row2-->

                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetPackage" TypeName="PackageDB">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="0" Name="packageId" SessionField="packageId" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>

         

        
    </div><!--end of container div-->
</asp:Content>


