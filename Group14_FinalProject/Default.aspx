<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dewrm.Test" %>
<!--
# Name: Ryan Dew
# email: dewrm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: 3rd
# Brief Description: This project displays leet code solutions (easy, medium and [hard])
# Citations: Chat GPT
# Anything else that's relevant:None
-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="LeetCodeEasy" runat="server" Text="Easy Problem" OnClick="LeetCodeEasy_Click" /> 
        </div>

        <div>
            <asp:Button ID="LeetCodeMedium" runat="server" Text="Medium Problem" OnClick="LeetCodeMedium_Click" />
        </div>
        <div>

            <asp:Button ID="LeetCodeHard" runat="server" Text="Hard Problem" OnClick="LeetCodeHard_Click" />

        </div>
    </form>
</body>
</html>


