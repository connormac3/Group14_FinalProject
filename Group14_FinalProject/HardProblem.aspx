<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HardProblem.aspx.cs" Inherits="Group14_FinalProject.HardProblem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
<form id="form1" runat="server">
<div>
<h1>Median of Sorted Arrays</h1>
</div>

<div>
    <h2>Find Median of Sorted Arrays</h2>
    <p>Enter values for nums1 (comma-separated):</p>
    <asp:TextBox ID="txtNums1" runat="server" TextMode="MultiLine"
    Rows="3" Columns="30"></asp:TextBox>
    <br />
    <p>Enter values for nums2 (comma-separated):</p>
    <asp:TextBox ID="txtNums2" runat="server" TextMode="MultiLine"
    Rows="3" Columns="30"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnCalculate" runat="server" Text="Calculate
    Median" OnClick="btnCalculate_Click" />
    <br />
    <br />
    <asp:TextBox ID="txtResult" runat="server" TextMode="MultiLine"
    Rows="3" Columns="30"></asp:TextBox>
    </div>
</form>

</body>
</html>
