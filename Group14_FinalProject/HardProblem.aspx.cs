using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_Group14
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Calculate the total length of the combined arrays
            int totalLength = nums1.Length + nums2.Length;

            // Check if the total length is odd or even to determine the median calculation method
            if (totalLength % 2 == 1)
            {
                // If the total length is odd, return the value of the (totalLength / 2 + 1)th element
                return FindKthElement(nums1, nums2, totalLength / 2 + 1);
            }
            else
            {
                // If the total length is even, return the average of the values of the (totalLength / 2)th and (totalLength / 2 + 1)th elements
                return (FindKthElement(nums1, nums2, totalLength / 2) + FindKthElement(nums1, nums2, totalLength / 2 + 1)) / 2.0;
            }
        }

        // Helper method to find the kth element in the combined sorted arrays
        private int FindKthElement(int[] nums1, int[] nums2, int k)
        {
            // Initialize indices for nums1 and nums2
            int index1 = 0, index2 = 0;

            // Loop until the kth element is found
            while (true)
            {
                // Check if nums1 is exhausted
                if (index1 == nums1.Length)
                {
                    // If nums1 is exhausted, return the kth element of nums2
                    return nums2[index2 + k - 1];
                }

                // Check if nums2 is exhausted
                if (index2 == nums2.Length)
                {
                    // If nums2 is exhausted, return the kth element of nums1
                    return nums1[index1 + k - 1];
                }

                // Check if k is reduced to 1 (base case)
                if (k == 1)
                {
                    // If k is 1, return the minimum of the first elements of nums1 and nums2
                    return Math.Min(nums1[index1], nums2[index2]);
                }

                // Calculate new indices for nums1 and nums2
                int newIndex1 = Math.Min(index1 + k / 2 - 1, nums1.Length - 1);
                int newIndex2 = Math.Min(index2 + k / 2 - 1, nums2.Length - 1);

                // Compare the middle elements of nums1 and nums2
                if (nums1[newIndex1] <= nums2[newIndex2])
                {
                    // If the middle element of nums1 is less than or equal to the middle element of nums2,
                    // discard the elements before newIndex1 in nums1 and move to the next iteration
                    k -= newIndex1 - index1 + 1;
                    index1 = newIndex1 + 1;
                }
                else
                {
                    // If the middle element of nums2 is less than the middle element of nums1,
                    // discard the elements before newIndex2 in nums2 and move to the next iteration
                    k -= newIndex2 - index2 + 1;
                    index2 = newIndex2 + 1;
                }
            }
        }

    }
}
