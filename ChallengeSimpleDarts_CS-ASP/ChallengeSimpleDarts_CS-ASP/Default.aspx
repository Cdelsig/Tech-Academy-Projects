<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Dart Game</h1>
            <p>
                <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Play Darts!" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
