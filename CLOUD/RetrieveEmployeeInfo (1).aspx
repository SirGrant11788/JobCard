<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrieveEmployeeInfo.aspx.cs" Inherits="CLOUD.RetrieveEmployeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtbNum" runat="server" OnTextChanged="txtbNum_TextChanged" Width="346px">EMPLOYEE NUMBER</asp:TextBox>
        <br />
        <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="LOAD" />
        <br />
        <asp:ListBox ID="lb" runat="server" Height="230px" OnSelectedIndexChanged="lb_SelectedIndexChanged" Width="346px"></asp:ListBox>
        <br />
        <asp:Button ID="btnHome" runat="server" Text="HOME" />
    </form>
</body>
</html>
