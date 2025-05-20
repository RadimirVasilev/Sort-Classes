using System.ComponentModel.Design;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 15, 16, 17, 18 };

            int index = BinarySearch(nums, 15, 0, nums.Length - 1);

            Console.WriteLine($"index is {index}, num = {nums[index]}");
        }

        public static int BinarySearch(int[] arr, int find, int start, int end)
        {
            if(end < start)
            {
                return -1;
            }
            else
            {
                int mid = (start + end) / 2;
                if (arr[mid] > find)
                {
                    return BinarySearch(arr, find, start, mid - 1);
                }
                else if (arr[mid] < find)
                {
                    return BinarySearch(arr, find, mid + 1, end);
                }
                else
                {
                    return mid;
                }
            }
            
        }
    }
}
