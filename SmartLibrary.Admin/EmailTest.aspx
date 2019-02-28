<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailTest.aspx.cs" Inherits="SmartLibrary.Admin.EmailTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
 <form id="form1" runat="server">
        <table border="0" cellpadding="10" cellspacing="10" id="tbl" runat="server" visible="false" width="1700px">
            <tr>
                <td colspan="2">
                    <asp:Label Text="" ID="lblError" runat="server" ForeColor="Red" />
                    <br />
                    <br />
                </td>
            </tr>         
            <tr>
                <td>To Email
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtEmailTo" Text="dipal.patel@internal.mail" Width="200px" />
                </td>
            </tr>
            <tr>
                <td>Email Template
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtEmailTemplate" Width="200px" />
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="btnSubmitAll" runat="server" OnClick="btnSubmitAll_Click" Text="Send All Email" /></td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Send Email" />
                </td>
            </tr>
        </table>
    </form>
</html>
