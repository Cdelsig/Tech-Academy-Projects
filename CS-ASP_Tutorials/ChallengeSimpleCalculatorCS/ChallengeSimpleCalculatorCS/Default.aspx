<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculatorCS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <span style="font-family:Helvetica, sans-serif;">First Value:</span>
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            <br />
            <span style="font-family:Helvetica, sans-serif;">Second Value:</span> 
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" Text="+" OnClick="addButton_Click" Width="25px" />
&nbsp;&nbsp;<asp:Button ID="subtractButton" runat="server" Text="-" OnClick="subtractButton_Click" Width="25px" />
&nbsp;&nbsp;<asp:Button ID="multiplyButton" runat="server" Text="*" OnClick="multiplyButton_Click" Width="25px" />
&nbsp;&nbsp;<asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" Width="25px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#66CCFF" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
    </form>
</body>
</html>
