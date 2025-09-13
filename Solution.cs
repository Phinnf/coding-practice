namespace Coding_Practice
{
    public class Solution
    {
        public bool HasDuplicate(int[] nums)
        {
            // Hashset solution
            //return new HashSet<int>(nums).Count < nums.Length;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;

        }
        public bool IsAnagram(string s, string t)
        {
            // Sorted string then compare other two
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] sChar = s.ToCharArray();
            char[] tChar = t.ToCharArray();

            Array.Sort(sChar);
            Array.Sort(tChar);

            return new string(sChar).SequenceEqual(new string(tChar));

            //if (s.Length != t.Length)
            //{
            //    return false;
            //}

            //Dictionary<char, int> countS = [];
            //Dictionary<char, int> countT = [];
            //for (int i = 0; i < s.Length; i++)
            //{
            //    countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
            //    countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
            //}
            //return countS.Count == countT.Count && !countS.Except(countT).Any();
        }
    }

}

