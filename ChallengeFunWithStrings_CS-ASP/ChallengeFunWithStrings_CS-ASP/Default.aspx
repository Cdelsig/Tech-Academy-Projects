<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFunWithStrings_CS_ASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Fun With Strings Challenge!!</h1>
            <br />
            <br />
            Reverse &quot;Carrie Del Signore&quot;: <asp:Label ID="reverseNameLabel" runat="server"></asp:Label>
            <br />
            <br />
            Reverse sequence &quot;Luke, Leia, Han, Chewbacca&quot;:
            <asp:Label ID="reverseStarWarsLabel" runat="server"></asp:Label>
            <br />
            <br />
            Use padding to make each name the same length:<br />
            &quot;Luke, Leia, Han, Chewbacca&quot;<br />
            <br />
            <asp:Label ID="padLabel" runat="server"></asp:Label>
            <br />
            <br />
            Fix the spelling errors in this string:<br />
            &quot;NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.&quot;<br />
            <br />
            <asp:Label ID="removeLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            ready???<br />
            <br />
&nbsp;<asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Go!" />
        </div>
    </form>
</body>
</html>
