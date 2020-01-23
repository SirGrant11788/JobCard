<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrieveJobCard.aspx.cs" Inherits="CLOUD.RetrieveJobCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtbNum" runat="server" OnTextChanged="txtbNum_TextChanged" Width="251px">JOB CARD NUMBER</asp:TextBox>
        <br />
        <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="LOAD" />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="198px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="251px"></asp:ListBox>
        <br />
        <asp:Button ID="btnHome" runat="server" Text="HOME" />
    </form>
</body>
</html>
