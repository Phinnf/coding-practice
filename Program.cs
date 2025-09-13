using System.Threading.Channels;

namespace Coding_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "car";
            string t = "arf";
            Console.WriteLine(solution.IsAnagram(s, t));
        }
    }

}
