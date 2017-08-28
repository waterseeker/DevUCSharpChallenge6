<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUCSharpChallenge6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>
            <asp:Image ID="epicSpiesPic" runat="server" Height="150px" ImageUrl="~\Images\epic-spies-logo.jpg" />
            <br />
            <br />
            Asset Performance Tracker</h1>
        Asset Name:
        <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged: <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuge Performed: <asp:TextBox ID="actsOfSubterfugeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addAssetButton" runat="server" Text="Add Asset" OnClick="addAssetButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
