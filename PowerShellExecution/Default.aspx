﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PowerShellExecution.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-size: medium; font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; text-align: center">
    <form id="form1" runat="server">
    <div>
     <table>
            <tr><td>&nbsp;</td><td><h1 align="left" style="text-align: center">PowerShell Command</h1></td></tr>
            <tr><td>&nbsp;</td><td style="font-size: medium; font-family: Calibri">&nbsp;</td></tr>
            <tr><td>&nbsp;</td><td>PowerShell Command</td></tr>
            <tr><td>
                <br />
                </td><td>
                <asp:TextBox ID="Input" runat="server" TextMode="MultiLine" Width="433px" Height="73px" ></asp:TextBox>
            </td></tr>
            <tr><td>
                &nbsp;</td><td>
                <asp:Button ID="ExecuteCode" runat="server" Text="Execute" Width="200" onclick="ExecuteCode_Click" />
            </td></tr>
                <tr><td>&nbsp;</td><td><h3>Result</h3></td></tr>
                <tr><td>
                    &nbsp;</td><td>
                    <asp:TextBox ID="ResultBox" TextMode="MultiLine" Width="700" Height="200" runat="server"></asp:TextBox>
                </td></tr>
        </table>
    </div>
    </form>
</body>
</html>
