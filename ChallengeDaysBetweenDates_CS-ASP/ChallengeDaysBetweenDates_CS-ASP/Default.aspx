<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeDaysBetweenDates_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How many days have elapsed?<br />
            <br />
            Choose one date:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Choose second date:<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Go" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
