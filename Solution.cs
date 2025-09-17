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
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var y = target - nums[i];
                if (prevMap.ContainsKey(y))
                {
                    return new int[] { prevMap[y], i };
                }
                prevMap[nums[i]] = i;
            }
            return new int[0];
        }
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramsWord = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] strChar = str.ToCharArray();
                Array.Sort(strChar);
                string sortedStr = new string(strChar);
                if (!anagramsWord.ContainsKey(sortedStr))
                {
                    anagramsWord[sortedStr] = new List<string>();
                }
                anagramsWord[sortedStr].Add(str);
            }
            return anagramsWord.Values.ToList<List<string>>();
            // testing
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> count = [];
            foreach (int num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }
            List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList();
            arr.Sort((a, b) => b[0].CompareTo(a[0]));
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = arr[i][1];
            }
            return res;
        }
    }
}

