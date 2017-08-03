<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesCS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 153px;
            height: 190px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="logo" class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <h1 class="auto-style2">Spy New Assignment Form</h1>
            Spy Code Name: <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name: <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        
            <br />
            <br />
            End Date of Previous Assignment:<asp:Calendar ID="endPrevCalendar" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment:<asp:Calendar ID="startNewCalendar" runat="server"></asp:Calendar>
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="endNewCalendar" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="assignButton" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        
        </div>
    </form>
</body>
</html>
