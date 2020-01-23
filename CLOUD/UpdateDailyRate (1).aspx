<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDailyRate.aspx.cs" Inherits="CLOUD.UpdateDailyRate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtbJobType" runat="server" OnTextChanged="txtbJobType_TextChanged" Width="308px">JOB TYPE</asp:TextBox>
            <br />
            <asp:TextBox ID="txtbRate" runat="server" OnTextChanged="txtbRate_TextChanged" Width="308px">DAILY RATE IN RANDS</asp:TextBox>
            <br />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="UPDATE" />
            <br />
            <asp:ListBox ID="lb" runat="server" Height="147px" Width="308px"></asp:ListBox>
            <br />
            <asp:Button ID="btnHome" runat="server" Text="HOME" />
        </div>
    </form>
</body>
</html>
