<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateEmployeeInfo.aspx.cs" Inherits="CLOUD.UpdateEmployeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtbNumToUpdate" runat="server" OnTextChanged="txtbNumToUpdate_TextChanged" Width="377px">EMPLOYEE NUMBER TO UPDATE</asp:TextBox>
        <br />
        <asp:TextBox ID="txtbNum" runat="server" OnTextChanged="txtbNum_TextChanged" Width="254px">EMPLOYEE NUMBER</asp:TextBox>
        <asp:Button ID="btnUpdateNum" runat="server" Text="UPDATE" OnClick="btnUpdateNum_Click1" />
        <br />
        <asp:TextBox ID="txtbName" runat="server" OnTextChanged="txtbName_TextChanged" Width="254px">EMPLOYEE NAME</asp:TextBox>
        <asp:Button ID="btnNameUpdate" runat="server" Text="UPDATE" OnClick="btnNameUpdate_Click1" />
        <br />
        <asp:TextBox ID="txtbSurnameUpdate" runat="server" OnTextChanged="txtbSurnameUpdate_TextChanged" Width="254px">EMPLOYEE SURNAME</asp:TextBox>
        <asp:Button ID="btnSurnameUpdate" runat="server" Text="UPDATE" OnClick="btnSurnameUpdate_Click1" />
        <br />
        <asp:ListBox ID="lb" runat="server" Height="188px" OnSelectedIndexChanged="lb_SelectedIndexChanged" Width="376px"></asp:ListBox>
        <br />
        <asp:Button ID="btnHome" runat="server" Text="HOME" OnClick="btnHome_Click1" />
    </form>
</body>
</html>
