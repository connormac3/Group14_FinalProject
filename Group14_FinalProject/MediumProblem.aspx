<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MediumProblem.aspx.cs" Inherits="Group14_FinalProject.MediumProblem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Roman Numeral Converter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Roman Numeral Converter</h2>
            <asp:Label ID="InputLabel" runat="server" Text="Enter an integer: "></asp:Label>
            <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="ConvertButton" runat="server" Text="Convert" OnClick="ConvertButton_Click" />
            <br /><br />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>