<%-- Author: (Terry) Soktheary Mao, Darya Ostapenko 
     Purpose: Form for Customer Registration
     Date: July 20, 2015 --%>

<%@ Page MasterPageFile="~/Main.master" Language="C#"  AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:content ID="headContent" ContentPlaceHolderID="headPlaceHolder" Runat="Server">  
    <link href="Styles/Registration.css" rel="stylesheet" />
    <style type="text/css">
    </style>
</asp:content>

<asp:Content ID="formPlaceHolder" ContentPlaceHolderID="formPlaceHolder" runat="Server">
    <br />
    <h1>Register Now!</h1>
    <br />
    <div id="registration">
        <asp:FormView ID="fvRegistration" runat="server" DataSourceID="ObjectDataSourceRegistration2" DefaultMode="Insert" HorizontalAlign="Center" Width="1000px" style="text-align: left" CellPadding="10" CellSpacing="10">
            <InsertItemTemplate>
                <table>
                <tr>
                    <td>Username: </td>
                    <td><asp:TextBox ID="CustUserNameTextBox" runat="server" Text='<%# Bind("CustUserName") %>' MaxLength="25" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="CustUserNameTextBox" Display="Dynamic" ErrorMessage="Username  is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password: </td>
                    <td><asp:TextBox ID="CustPasswordTextBox" runat="server" Text='<%# Bind("CustPassword") %>' MaxLength="25" TextMode="Password" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="CustPasswordTextBox" Display="Dynamic" ErrorMessage="Password  is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password: </td>
                    <td><asp:TextBox ID="ConfirmPasswordTextBox" runat="server" Text='' MaxLength="25" TextMode="Password" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="CustPasswordTextBox" Display="Dynamic" ErrorMessage="Confirm password  is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="CustPasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="Password must be the same." ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>First Name: </td>
                    <td><asp:TextBox ID="CustFirstNameTextBox" runat="server" Text='<%# Bind("CustFirstName") %>' MaxLength="25" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CustFirstNameTextBox" Display="Dynamic" ErrorMessage="First Name  is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Last Name: </td>
                    <td><asp:TextBox ID="CustLastNameTextBox" runat="server" Text='<%# Bind("CustLastName") %>' MaxLength="25" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CustLastNameTextBox" Display="Dynamic" ErrorMessage="Last Name is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Address: </td>
                    <td><asp:TextBox ID="CustAddressTextBox" runat="server" Text='<%# Bind("CustAddress") %>' MaxLength="50" Width="250px" TextMode="MultiLine" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="CustAddressTextBox" Display="Dynamic" ErrorMessage="Address  is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>City: </td>
                    <td><asp:TextBox ID="CustCityTextBox" runat="server" Text='<%# Bind("CustCity") %>' MaxLength="50" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="CustCityTextBox" Display="Dynamic" ErrorMessage="City is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Province Code: </td>
                    <td><asp:TextBox ID="CustProvTextBox" runat="server" Text='<%# Bind("CustProv") %>' MaxLength="2" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="CustProvTextBox" Display="Dynamic" ErrorMessage="Province is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="CustProvTextBox" Display="Dynamic" ErrorMessage="Province is not valid, i.e AB or ab." ForeColor="Red" ValidationExpression="^(?:AB|ab|BC|bc|MB|mb|N[BLTSU]|n[bltsu]|ON|on|PE|pe|QC|qc|SK|sk|YT|yt)*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Postal Code:</td>
                    <td><asp:TextBox ID="CustPostalTextBox" runat="server" Text='<%# Bind("CustPostal") %>' MaxLength="7" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="CustPostalTextBox" Display="Dynamic" ErrorMessage="Postal Code is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="CustPostalTextBox" Display="Dynamic" ErrorMessage="Postal Code must be valid, ie. A1A 2B3." ForeColor="Red" ValidationExpression="[AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvXxYy][0-9][AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvWwXxYyZz] ?[0-9][AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvWwXxYyZz][0-9]"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Country: </td>
                    <td class="auto-style4"><asp:TextBox ID="CustCountryTextBox" runat="server" Text='<%# Bind("CustCountry") %>' MaxLength="25" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="CustCountryTextBox" Display="Dynamic" ErrorMessage="Country is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Home Phone: </td>
                    <td><asp:TextBox ID="CustHomePhoneTextBox" runat="server" Text='<%# Bind("CustHomePhone") %>' MaxLength="20" Width="250px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="CustHomePhoneTextBox" Display="Dynamic" ErrorMessage="Home Phone is a required field." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="CustHomePhoneTextBox" Display="Dynamic" ErrorMessage="Phone number must have be a valid number." ForeColor="Red" ValidationExpression="^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$" ToolTip="Can have numbers, brackets, ex 123"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Business Phone: </td>
                    <td><asp:TextBox ID="CustBusPhoneTextBox" runat="server" Text='<%# Bind("CustBusPhone") %>' MaxLength="20" Width="250px" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="CustBusPhoneTextBox" Display="Dynamic" ErrorMessage="Please enter a valid phone number." ForeColor="Red" ValidationExpression="^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$" ToolTip="Can have numbers, brackets, ex 123"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email: </td>
                    <td><asp:TextBox ID="CustEmailTextBox" runat="server" Text='<%# Bind("CustEmail") %>' MaxLength="50" Width="250px" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="CustEmailTextBox" Display="Dynamic" ErrorMessage="Please enter a valid email." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ToolTip="i.e. abc@abc.com"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                </table>
                <br />
                <asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Register" OnClick="InsertButton_Click"/>
                &nbsp;<asp:Button ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" PostBackUrl="~/Home.aspx" />
                <br />
            </InsertItemTemplate>
        </asp:FormView>
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="#33CC33" Font-Size="Larger"></asp:Label>
        <asp:ObjectDataSource ID="ObjectDataSourceRegistration2" runat="server" DataObjectTypeName="Customer" InsertMethod="AddCustomer" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomer" TypeName="CustomerDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="fvRegistration" Name="CustomerId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        

    </div>
</asp:Content>


