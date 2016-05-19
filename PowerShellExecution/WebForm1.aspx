<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PowerShellExecution.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>Virtual IT Support</title>
    <link href="Content/bootstap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1 class="text-center">Virtual IT Support</h1>
            <div style="z-index: 1; left: 26px; top: 157px; position: absolute; height: 165px; width: 304px">
                <div style="z-index: 1; left: 11px; top: 88px; position: absolute; height: 67px; width: 128px">
                    <asp:Button ID="EnableMimix" runat="server" OnClick="EnableMimix_Click" Text="Enable" Width="127px" />
                    &nbsp;
                </div>
                <div style="z-index: 1; left: 161px; top: 87px; position: absolute; height: 67px; width: 128px">
                    <asp:Button ID="DisableMimix" runat="server" OnClick="DisableMimix_Click" Text="Disable" Width="127px" />
                    &nbsp;

                </div>
            </div>
        </div>
        <div style="height: 61px; width: 285px; z-index: 1; left: 32px; top: 170px; position: absolute">
            <h2>&nbsp;Mimix Account</h2>
            &nbsp;
        </div>
    </form>
</body>
</html>
