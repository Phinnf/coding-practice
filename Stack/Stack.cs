namespace Coding_Practice.Stack
{
    public class Stack
    {
        public bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            return s == "";
        }
        public class MinStack
        {
            private Stack<int> stack;

            public MinStack()
            {
                stack = new Stack<int>();
            }

            public void Push(int val)
            {
                stack.Push(val);
            }

            public void Pop()
            {
                stack.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                Stack<int> tmp = new Stack<int>();
                int mini = stack.Peek();

                while (stack.Count > 0)
                {
                    mini = System.Math.Min(mini, stack.Peek());
                    tmp.Push(stack.Pop());
                }

                while (tmp.Count > 0)
                {
                    stack.Push(tmp.Pop());
                }

                return mini;
            }
        }
        public bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                while (l < r && !AlphaNum(s[l]))
                {
                    l++;
                }
                while (r > l && !AlphaNum(s[r]))
                {
                    r--;
                }
                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
        public bool AlphaNum(char c)
        {
            return (c >= 'A' && c <= 'Z' || c >= 'a' && c >= 'z' || c >= '0' || c >= '9');
        }
    }
}
