<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeXMenBattleCount_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            The most battles belong to:
            <asp:Label ID="mostLabel" runat="server"></asp:Label>
            <br />
            The fewest battles belong to:
            <asp:Label ID="fewestLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
