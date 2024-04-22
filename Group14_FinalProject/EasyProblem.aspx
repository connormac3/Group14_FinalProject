<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EasyProblem.aspx.cs" Inherits="Group14_FinalProject.EasyProblem" %>

<!-- 
# Name: Connor MacFarland
# email: macfarct@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: 3rd
# Brief Description: This project displays leet code solutions (easy, medium and hard)
# Citations: Gemini
# Anything else that's relevant:
 -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Max Achievable Number</h2>
            <p> You are given two integers, num and t.</p>

<p> integer x is called achievable if it can become equal to num after applying the following operation no more than t times:</p>
<p>Increase or decrease x by 1, and simultaneously increase or decrease num by 1.</p>
<p>Return the maximum possible achievable number. It can be proven that there exists at least one achievable number.</p>

            <p>Enter value for num:</p>
            <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
            <br />
            <p>Enter value for t:</p>
            <asp:TextBox ID="txtT" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnCalculate" runat="server" Text="Calculate" OnClick="BtnCalculate_Click1" />
            <br />
            <br />
            <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
