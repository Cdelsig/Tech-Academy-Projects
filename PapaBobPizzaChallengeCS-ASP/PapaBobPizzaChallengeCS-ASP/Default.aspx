<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobPizzaChallengeCS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 185px;
            height: 181px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            color: #CC0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <img alt="Logo" class="auto-style1" src="PapaBob.png" /><span class="auto-style2"><strong>Papa Bob&#39;s Pizza and Software</strong></span></h1>
            <div>
                <asp:RadioButton ID="smallRadioButton" runat="server" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10.00" />
                <br />
                <asp:RadioButton ID="mediumRadioButton" runat="server" GroupName="pizzaSize" Text="Mama Bob Size (13&quot;) - $13.00" />
                <br />
                <asp:RadioButton ID="largeRadioButton" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) - $16.00" />
                <br />
                <br />
                <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="crustGroup" Text="Thin Crust" />
                <br />
                <asp:RadioButton ID="deepDishRadioButton" runat="server" GroupName="crustGroup" Text="Deep Dish (+$2.00)" />
                <br />
                <br />
                <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
                <br />
                <asp:CheckBox ID="onionCheckBox" runat="server" Text="Onions (+$0.75)" />
                <br />
                <asp:CheckBox ID="greenPepperCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
                <br />
                <asp:CheckBox ID="redPepperCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
                <br />
                <asp:CheckBox ID="anchovyCheckBox" runat="server" Text="Anchovy (+$2.00)" />
                <br />
                <h3><span class="auto-style2">Papa Bob&#39;s <span class="auto-style3">Special Deal</span></span></h3>
                Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
                <br />
                <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
                <br />
                <br />
                Total: <asp:Label ID="totalLabel" runat="server" Text=" $0.00"></asp:Label>
                <br />
                <br />
                Sorry, you can only order one pizza online for pick-up.. better website coming in future challenge!</div>
        </div>
    </form>
</body>
</html>
