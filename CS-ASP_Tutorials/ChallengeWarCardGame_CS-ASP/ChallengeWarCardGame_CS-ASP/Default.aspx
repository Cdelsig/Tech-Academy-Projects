<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeWarCardGame_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WAR!</h1>
            <h2>What is it good for??? Playing cards, of course!</h2>
            <p>
                Ready? Let&#39;s play!</p>
            <p>
                <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Go!" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
