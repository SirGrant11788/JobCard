<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateJobCard.aspx.cs" Inherits="CLOUD.CreateJobCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtbJobCardNo" runat="server" OnTextChanged="txtbJobCardNo_TextChanged" Width="356px">JOB CARD NUMBER</asp:TextBox>
        <br />
        <asp:TextBox ID="txtbJobTypeNo" runat="server" OnTextChanged="txtbJobTypeNo_TextChanged" Width="356px">JOB TYPE NUMBER</asp:TextBox>
        <br />
        <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="txtCustomerID_TextChanged" Width="356px">CUSTOMER ID</asp:TextBox>
        <br />
        <asp:TextBox ID="txtbDays" runat="server" OnTextChanged="txtbDays_TextChanged" Width="356px">NUMBER OF DAYS</asp:TextBox>
        <br />
        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="CREATE" />
        <br />
        <asp:ListBox ID="lb" runat="server" Height="131px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="356px"></asp:ListBox>
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="HOME" />
    </form>
</body>
</html>
