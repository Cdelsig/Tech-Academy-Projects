<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeMegaCasino_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
            font-weight: normal;
        }
        .auto-style2 {}
        #form1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Angel&#39;s Super Mega Casino!!!</h1>
       
            <br />
       
        </div>
        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Place Your Bet:
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" Text="Pull the Lever!" OnClick="leverButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Player&#39;s Money:
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry - 2x Your Bet<br />
        2 Cherries - 3x Your Bet<br />
        3 Cherries - 4x Your Bet<br />
        <br />
        3 7&#39;s - Jackpot!!! - 100x Your Bet<br />
        <br />
        HOWEVER...<br />
        <br />
        If there&#39;s even one BAR, you lose.</form>
</body>
</html>
