<%-- Author: Darya Ostapenko
     Purpose: WebForm for CustomerPackages(CustomerInformation button)
     Date: July 21, 2015 --%>

<%@ Page MasterPageFile="~/Main.master" Language="C#" AutoEventWireup="true" CodeFile="CustomerPackages.aspx.cs" Inherits="CustomerPackages" %>
<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">
    <link href="Styles/CustomerPackages.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <div id="containerInfo">
            <h1>Packages for the Customer:</h1>
            <br />
            <asp:Label ID="lblPasswordChanged" runat="server" ForeColor="#00CC00" Text="Your password has been successfully changed!" Visible="False"></asp:Label>
            <asp:FormView ID="fvChangePassword" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="CustomerId" HorizontalAlign="Center" style="text-align: left" Height="50px" Width="700px">
                <EditItemTemplate>
                    <table>
                        <tr>
                            <td>  
                            </td>
                            <td>
                                <asp:Label ID="CustUserNameTextBox" runat="server" Text='<%# Bind("CustUserName") %>' ReadOnly="True" Visible="False" />
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td> 
                            </td>
                            <td>
                                <asp:Label ID="CustFirstNameTextBox" runat="server" Text='<%# Bind("CustFirstName") %>' ReadOnly="True" Visible="False" />
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                New Password:
                            </td>
                            <td>
                                <asp:TextBox ID="CustPasswordTextBox" runat="server" Text='<%# Bind("CustPassword") %>' TextMode="Password" />
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="CustPasswordTextBox" Display="Dynamic" ErrorMessage="New Password is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Confirm Password:
                            </td>
                            <td>
                                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" Text='' TextMode="Password" />
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ConfirmPasswordTextBox" Display="Dynamic" ErrorMessage="Confirm Password is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="CustPasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" Display="Dynamic" ErrorMessage="Passwords must be the same." ForeColor="Red"></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Save" OnClick="UpdateButton_Click" />
                    &nbsp;<asp:Button ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>

                <ItemTemplate>
                    Welcome, <asp:Label ID="CustWelcomeMessage" runat="server" Text='<%# Bind("CustFirstName") %>'/>! You can change your password here.
                    <asp:Button ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Change Password" />
                </ItemTemplate>
            </asp:FormView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelExpertsConnectionString %>" SelectCommand="SELECT [CustomerId], [CustUserName], [CustPassword], [CustFirstName] FROM [Customers] WHERE ([CustomerId] = @CustomerId)" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerId] = @CustomerId" InsertCommand="INSERT INTO [Customers] ([CustUserName], [CustPassword], [CustFirstName]) VALUES (@CustUserName, @CustPassword, @CustFirstName)" UpdateCommand="UPDATE [Customers] SET [CustUserName] = @CustUserName, [CustPassword] = @CustPassword, [CustFirstName] = @CustFirstName WHERE [CustomerId] = @CustomerId">
                <DeleteParameters>
                    <asp:Parameter Name="CustomerId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CustUserName" Type="String" />
                    <asp:Parameter Name="CustPassword" Type="String" />
                    <asp:Parameter Name="CustFirstName" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:SessionParameter Name="CustomerId" SessionField="customerId" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CustUserName" Type="String" />
                    <asp:Parameter Name="CustPassword" Type="String" />
                    <asp:Parameter Name="CustFirstName" Type="String" />
                    <asp:Parameter Name="CustomerId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource2" 
            Height="50px" HorizontalAlign="Center" Width="503px"
            HeaderStyle-ForeColor="white" HeaderStyle-BackColor="#0099cc" RowStyle-ForeColor="#0099cc"
            RowStyle-BackColor="White" AlternatingRowStyle-BackColor="#99EBFF" AlternatingRowStyle-ForeColor="#000"
            cellpadding="5" OnDataBound="DetailsView1_DataBound">
<AlternatingRowStyle BackColor="#99EBFF" ForeColor="#000000"></AlternatingRowStyle>
            <Fields>
                <asp:TemplateField HeaderText="Customer Id" SortExpression="CustomerId">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("CustomerId") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("CustomerId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer First Name" SortExpression="CustFirstName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CustFirstName") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="First Name is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("CustFirstName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Last Name" SortExpression="CustLastName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("CustLastName") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Last Name is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CustLastName") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("CustLastName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Address" SortExpression="CustAddress">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("CustAddress") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Address is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("CustAddress") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("CustAddress") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer City" SortExpression="CustCity">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("CustCity") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="City is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("CustCity") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("CustCity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Province" SortExpression="CustProv">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("CustProv") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="Province is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="Province is not valid. Canadian Provinces only." ForeColor="Red" ValidationExpression="^(?:AB|ab|BC|bc|MB|mb|N[BLTSU]|n[bltsu]|ON|on|PE|pe|QC|qc|SK|sk|YT|yt)*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("CustProv") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("CustProv") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Postal" SortExpression="CustPostal">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("CustPostal") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Postal Code is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Postal Code must be valid, ie. A1A 2B3." ForeColor="Red" ValidationExpression="[AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvXxYy][0-9][AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvWwXxYyZz] ?[0-9][AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvWwXxYyZz][0-9]"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("CustPostal") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("CustPostal") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Country" SortExpression="CustCountry">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("CustCountry") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" Display="Dynamic" ErrorMessage="Country is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("CustCountry") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("CustCountry") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Home Phone" SortExpression="CustHomePhone">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("CustHomePhone") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" Display="Dynamic" ErrorMessage="Home Phone is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox8" Display="Dynamic" ErrorMessage="Phone number must be valid." ForeColor="Red" ToolTip="Can have numbers, brackets, ex 123" ValidationExpression="^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("CustHomePhone") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("CustHomePhone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Bus Phone" SortExpression="CustBusPhone">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("CustBusPhone") %>'></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="Business Phone number must be valid." ForeColor="Red" ToolTip="Can have numbers, brackets, ex 123" ValidationExpression="^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("CustBusPhone") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("CustBusPhone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer Email" SortExpression="CustEmail">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("CustEmail") %>'></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox10" Display="Dynamic" ErrorMessage="Please enter a valid email." ForeColor="Red" ToolTip="i.e. abc@abc.com" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("CustEmail") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Bind("CustEmail") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Customer UserName" SortExpression="CustUserName">
                    <EditItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("CustUserName") %>'></asp:Label>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("CustUserName") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Bind("CustUserName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Agent Id" SortExpression="AgentId">
                    <EditItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("AgentId") %>'></asp:Label>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("AgentId") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label13" runat="server" Text='<%# Bind("AgentId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
            </Fields>

            <FooterTemplate>
                <asp:Label ID="lblFinalAmount" runat="server" Font-Bold="True" ForeColor="#15678E"></asp:Label>
            </FooterTemplate>

<HeaderStyle BackColor="#0099CC" ForeColor="White"></HeaderStyle>

<RowStyle BackColor="White" ForeColor="#0099CC"></RowStyle>
        </asp:DetailsView>
          
       
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetTotalAmountDue" TypeName="InvoiceDB">
                <SelectParameters>
                    <asp:SessionParameter Name="CustomerId" SessionField="customerId" Type="Int32" />
                </SelectParameters>
        </asp:ObjectDataSource>
    
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" 
            SelectMethod="GetCustomer" TypeName="CustomerDB" UpdateMethod="UpdateCustomer" ConflictDetection="CompareAllValues" DataObjectTypeName="Customer" >
            <SelectParameters>
                <asp:SessionParameter Name="CustomerId" SessionField="customerId" Type="Int32" DefaultValue="0" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="original_Customer" Type="Object" />
                <asp:Parameter Name="customer" Type="Object" />
            </UpdateParameters>
        </asp:ObjectDataSource>
      
    
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackagesByCustomerId" 
            TypeName="BookPackageDB">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="-1" Name="customerId" SessionField="customerId" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

        <div class="h2Style">
            Summary of Packages Purchased
        </div>
        <div class="rounded_corners" style="width:70%; text-align: center; margin-left: 15%;">
        <asp:GridView ID="GridView1" runat="server" width="100%" HorizontalAlign="Center"
            HeaderStyle-ForeColor="white" HeaderStyle-BackColor="#0099cc"
            RowStyle-BackColor="White" AlternatingRowStyle-BackColor="#99EBFF" AlternatingRowStyle-ForeColor="#000"
            AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowPaging="True" >

<AlternatingRowStyle BackColor="#99EBFF" ForeColor="#000000"></AlternatingRowStyle>

            <Columns>
                <asp:BoundField DataField="BookingDate" HeaderText="Booking Date" SortExpression="BookingDate" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="PackageId" HeaderText="PackageId" SortExpression="PackageId" />
                <asp:BoundField DataField="PkgName" HeaderText="Package Name" SortExpression="PkgName"  />
                <asp:BoundField DataField="PkgDesc" HeaderText="Package Description" SortExpression="PkgDesc"  />
                <asp:BoundField DataField="PkgStartDate" HeaderText="Package Start Date" SortExpression="PkgStartDate" DataFormatString="{0:yyyy-MM-dd}"/>
                <asp:BoundField DataField="PkgEndDate" HeaderText="Package End Date" SortExpression="PkgEndDate" DataFormatString="{0:yyyy-MM-dd}"/>
                <asp:BoundField DataField="PkgBasePrice" HeaderText="Package Price" SortExpression="PkgBasePrice" DataFormatString="{0:c}"/>
                <asp:BoundField DataField="BookingNo" HeaderText="Booking No" SortExpression="BookingNo" />
                <asp:BoundField DataField="TravelerCount" HeaderText="Traveler Count" SortExpression="TravelerCount" />
            </Columns>

<HeaderStyle BackColor="#0099CC" ForeColor="White"></HeaderStyle>

<RowStyle BackColor="White"></RowStyle>
        </asp:GridView>
        </div>
        <!-- end of rounded corners div-->


            <div id="labelTotalAmountPackages">
                <asp:Label ID="lblTotalAmountForPackages" runat="server" CssClass="label" Font-Bold="True" 
                    Font-Size="Large" ForeColor="#0099CC" ></asp:Label>
          </div>
            <div class="h2Style">
                Products Purchased
            </div>
            <div class="rounded_corners" style="width:70%; text-align: center; margin-left: 15%;">
            <asp:GridView ID="GridView2" runat="server" width="100%" 
            HeaderStyle-ForeColor="white" HeaderStyle-BackColor="#0099cc"
            RowStyle-BackColor="White" AlternatingRowStyle-BackColor="#99EBFF" AlternatingRowStyle-ForeColor="#000"
            AutoGenerateColumns="False" PageSize="5" 
                DataSourceID="ObjectDataSource6" HorizontalAlign="Center" AllowPaging="True" >
<AlternatingRowStyle BackColor="#99EBFF" ForeColor="#000000"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="bookingNo" HeaderText="Booking No" SortExpression="bookingNo" />
                    <asp:BoundField DataField="FeeName" HeaderText="Fee Name" SortExpression="FeeName" />
                    <asp:BoundField DataField="FeeAmt" HeaderText="Fee Amount" SortExpression="FeeAmt" DataFormatString="{0:c}"/>
                    <asp:BoundField DataField="ProdName" HeaderText="Product Name" SortExpression="ProdName" />
                    <asp:BoundField DataField="BasePrice" HeaderText="Base Price" SortExpression="BasePrice" DataFormatString="{0:c}"/>
                

            </Columns> 

<HeaderStyle BackColor="#0099CC" ForeColor="White"></HeaderStyle>

<RowStyle BackColor="White"></RowStyle>
            </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetInvoiceForProducts" TypeName="InvoiceDB">
                    <SelectParameters>
                        <asp:SessionParameter Name="CustomerId" SessionField="customerId" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource4" runat="server"></asp:ObjectDataSource>
        </div>
        <!-- end of rounded corners div-->


                <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetInvoice" TypeName="InvoiceDB">
                    <SelectParameters>
                        <asp:SessionParameter Name="CustomerId" SessionField="customerId" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>


        <div id="labelTotalAmountProducts">
                <asp:Label ID="lblTotalAmountForProducts" runat="server" CssClass="label" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#0099CC" HorizontalAlign="Right"></asp:Label>
            </div>
            <br />
            <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
            <br />
            <br />
            <br />
            <br />
            <br />


        </div>
</asp:Content>
