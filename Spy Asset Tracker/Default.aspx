<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Spy_Asset_Tracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Asset Performance Tracker</h1>
        <p>
            Asset Name:
            <asp:TextBox ID="assetNameTextbox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:
            <asp:TextBox ID="electionsTextbox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:
            <asp:TextBox ID="subterfugeTextbox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
