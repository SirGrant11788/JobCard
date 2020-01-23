<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmployeeInfo.aspx.cs" Inherits="CLOUD.CreateEmployeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtbEmpNo" runat="server" OnTextChanged="txtbEmpNo_TextChanged" Width="256px">EMPLOYEE NUMBER</asp:TextBox>
        <br />
        <asp:TextBox ID="txtbName" runat="server" OnTextChanged="txtbName_TextChanged" Width="256px">EMPLOYEE NAME</asp:TextBox>
        <br />
        <asp:TextBox ID="txtbSurname" runat="server" OnTextChanged="txtbSurname_TextChanged" Width="256px">EMPLOYEE SURNAME</asp:TextBox>
        <br />
        <asp:Button ID="btnCreate" runat="server" Text="CREATE" />
        <br />
        <asp:ListBox ID="lb" runat="server" Height="204px" Width="256px"></asp:ListBox>
        <br />
        <asp:Button ID="BtnHome" runat="server" Text="HOME" />
    </form>
</body>
</html>
