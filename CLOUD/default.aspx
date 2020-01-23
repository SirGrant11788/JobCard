<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CLOUD.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Button ID="btnCreateJobCard" runat="server" OnClick="btnCreateJobCard_Click" Text="Create Job Card" Width="270px" />
                    <br />
                    <asp:Button ID="btnRetrieveJobCard" runat="server" OnClick="btnRetrieveJobCard_Click" Text="Retrieve Job Card" Width="270px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCreateCustomerInvoice" runat="server" OnClick="btnCreateCuatomerQuote_Click" Text="Create Customer Invoice" Width="270px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUpdateEmployeeInfo" runat="server" OnClick="btnUpdateEmployeeInfo_Click" Text="Update Employee Info" Width="270px" />
                    <br />
                    <asp:Button ID="btnRetrieveEmployeeInfo" runat="server" OnClick="btnRetrieveEmployeeInfo_Click" Text="Retrieve Employee Info" Width="270px" />
                    <br />
                    <asp:Button ID="btnCreateEmployeeInfo" runat="server" OnClick="btnCreateEmployeeInfo_Click" Text="Create Employee Info" Width="270px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="btnUpdateDailyRate" runat="server" OnClick="btnUpdateDailyRate_Click" Text="Update Job Type  Daily Rate" Width="270px" />
    </form>
</body>
</html>
