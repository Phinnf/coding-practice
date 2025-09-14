using System.Threading.Channels;

namespace Coding_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "car";
            string t = "arc";
            Console.WriteLine(solution.IsAnagram(s, t));

            int[] nums = { 2, 11, 11, 7 };
            int[] result = solution.TwoSum(nums, 9);
            Console.WriteLine("\n[" + string.Join(",", result) + "]");
            
        }
    }

}
