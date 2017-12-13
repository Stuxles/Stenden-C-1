<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Scenario4_3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <h2>Test Form For TextWebService</h2>
        <p>
            <asp:TextBox ID="TextBox1"
                runat="server"
                Text="enter text" />
            <br />
            <asp:Button ID="Button1"
                runat="server"
                Text="Invoke Service Methods"
                OnClick="Button1_Click" />
        </p>
        <p>
            <strong>Results:</strong><br />
            ToLower method:
            <asp:Label ID="toLowerLabel"
                runat="server"
                Text="Label" ForeColor="Green" />
            <br />
            ToUpper method:
        <asp:Label ID="toUpperLabel"
            runat="server"
            Text="Label" ForeColor="Green" />
        </p>
    </form>
</body>
</html>
