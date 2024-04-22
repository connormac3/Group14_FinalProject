<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HardProblem.aspx.cs" Inherits="Group14_FinalProject.HardProblem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Median Finder</title>
 </head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Main header -->
            <h1>Median of Sorted Arrays</h1>
           
            <div>
                <!-- Section header -->
                <h2>Find Median of Sorted Arrays</h2>
                
                <!-- Explanation of the input -->
                <p>
                    To find the median of two sorted arrays, please enter the values for each array below.
                    Separate the values with commas.
                </p>
                
                <!-- Label and input box for nums1 -->
                <p>
                    <strong>Array nums1:</strong>
                    Enter sorted numbers (comma-separated):
                </p>
                <asp:TextBox ID="txtNums1" runat="server" TextMode="MultiLine" Rows="3" Columns="30"></asp:TextBox>
                <br />
                
                <!-- Label and input box for nums2 -->
                <p>
                    <strong>Array nums2:</strong>
                    Enter sorted numbers (comma-separated):
                </p>
                <asp:TextBox ID="txtNums2" runat="server" TextMode="MultiLine" Rows="3" Columns="30"></asp:TextBox>
                <br />
                <br />
                
                <!-- Button to trigger the calculation -->
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate Median" OnClick="btnCalculate_Click" />
                <br />
                <br />
                
                <!-- Display the result -->
                <!-- Header for the result -->
                <h3>Result:</h3>
                <!-- Label to display the calculated median -->
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>

</html>
