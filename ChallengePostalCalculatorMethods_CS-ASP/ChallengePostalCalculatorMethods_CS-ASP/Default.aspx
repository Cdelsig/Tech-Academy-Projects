<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorMethods_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width (inches):
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
            <br />
            Height (inches):
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
            <br />
            Length (inches):
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" OnCheckedChanged="handleChange" Text="Ground" GroupName="deliveryType" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" OnCheckedChanged="handleChange" Text="Air" GroupName="deliveryType" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" OnCheckedChanged="handleChange" Text="Next Day" GroupName="deliveryType" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
