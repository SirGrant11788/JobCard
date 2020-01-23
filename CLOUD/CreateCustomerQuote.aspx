<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCustomerQuote.aspx.cs" Inherits="CLOUD.CreateCustomerQuote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtbCustomerID" runat="server" OnTextChanged="txtbCustomerID_TextChanged" Width="446px">ENTER CUSTOMER ID FOR QUOTE</asp:TextBox>
        <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="LOAD" />
        <br />
        <asp:ListBox ID="lb" runat="server" Height="708px" OnSelectedIndexChanged="lb_SelectedIndexChanged" Width="531px"></asp:ListBox>
        <p>
            <asp:Button ID="btnHome" runat="server" Text="HOME" OnClick="btnHome_Click1" />
        </p>
    </form>
</body>
</html>
