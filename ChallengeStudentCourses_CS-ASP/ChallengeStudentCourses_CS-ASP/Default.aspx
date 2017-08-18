<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeStudentCourses_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sample Student Schedule</h1>
            
                <asp:Button ID="Button1" runat="server" Text="Assignment 1" OnClick="Button1_Click" />
            
            
                <br />
            <br />
            
            
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Assignment 2" />
            
            
                <br />
            <br />
            
            
                <asp:Button ID="Button3" runat="server" Text="Assignment 3" OnClick="Button3_Click" />
            
            
                <br />
            <br />
            
            
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            
            
            
        </div>
    </form>
</body>
</html>
