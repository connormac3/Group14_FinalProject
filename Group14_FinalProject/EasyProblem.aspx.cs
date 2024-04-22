/*
# Name: Connor MacFarland
# email: macfarct@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: 3rd
# Brief Description: This project displays leet code solutions (easy, medium and hard)
# Citations: Gemini
# Anything else that's relevant:
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group14_FinalProject
{
    public partial class EasyProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnCalculate_Click1(object sender, EventArgs e)
        {
            // Parse input values
            int num = int.Parse(txtNum.Text);
            int t = int.Parse(txtT.Text);

            // Create an instance of the Solution class
            Solution solution = new Solution();

            // Get the solution
            int maxAchievable = solution.MaxAchievable(num, t);

            // Display the solution
            txtResult.Text = maxAchievable.ToString();

        }
    }
}

public class Solution
{
    public int MaxAchievable(int num, int t)
    {
        int MaximumAchievableX = num + t; // Start with the maximum achievable value
        return num + (2 * t);

        // Adjust maxAchievable based on the remaining number of operations
        // if (t % 2 == 1) // If t is odd, we can only do (t-1)/2 increments and (t-1)/2 decrements
        //  {
        //  maxAchievable--;
        // }

        // return maxAchievable;
    }
}


    
