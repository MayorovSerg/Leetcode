using System.Linq;

namespace Problem_004
{
    public class Solution {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var total = nums1.Length + nums2.Length;
            var mid = total / 2;
            var i1 = 0;
            var i2 = 0;
            var count = 0;

            var arr = new int[total % 2 == 0 ? 2 : 1];

            while (nums1.Length > i1 && nums2.Length > i2)
            {
                if (mid >= count)
                {
                    if (nums1[i1] > nums2[i2])
                    {
                        arr[count % arr.Length] = nums2[i2++];
                        count++;
                    }
                    else
                    {
                        arr[count % arr.Length] = nums1[i1++];
                        count++;
                    }
                }
                else
                {
                    return arr.Sum() / (double) arr.Length;
                }
            }

            while (mid >= count && nums1.Length > i1)
            {
                arr[count % arr.Length] = nums1[i1++];
                count++;
            }

            while (mid >= count && nums2.Length > i2)
            {
                arr[count % arr.Length] = nums2[i2++];
                count++;
            }

            return arr.Sum() / (double) arr.Length;
        }
    }
}