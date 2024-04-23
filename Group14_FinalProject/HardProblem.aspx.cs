/*
# Name: Ryan Dew
# email: dewrm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: 3rd
# Brief Description: This project displays leet code solutions (easy, medium and [hard])
# Citations: Chat GPT
# Anything else that's relevant:None
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group14_FinalProject
{
    public partial class HardProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse input arrays
            int[] nums1 = Array.ConvertAll(txtNums1.Text.Split(','),
            int.Parse);
            int[] nums2 = Array.ConvertAll(txtNums2.Text.Split(','),
            int.Parse);

            // Call the FindMedianSortedArrays method
            double median = FindMedianSortedArrays(nums1, nums2);

            // Display the result in the text box
            txtResult.Text = $"Median of sorted arrays: {median}";
        }



        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var sizeA = nums1.Length;
            var sizeB = nums2.Length;
            var union = new int[sizeA + sizeB];

            var isEven = (sizeA + sizeB) % 2 == 0;
            var center = (sizeA + sizeB) / 2;

            Array.Copy(nums1, 0, union, 0, sizeA);
            Array.Copy(nums2, 0, union, sizeA, sizeB);
            Array.Sort(union);

            return isEven ? (union[center - 1] + union[center]) / 2D :
            union[center];
        }
    }
}
